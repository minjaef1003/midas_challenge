using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midas_challenge
{
    public class Line
    {
        protected Point startPoint;
        protected Point endPoint;

        public Point StartPoint { get => startPoint; set => startPoint = value; }
        public Point EndPoint { get => endPoint; set => endPoint = value; }

        public double slope = -1.0;
        public Line()
        {

        }
        public Line(Point sp, Point ep)
        {
            startPoint = sp;
            endPoint = ep;
        }
    }

    public class Wall : Line
    {
        public Wall()
        {

        }
        public Wall(Point sp, Point ep)
        {
            startPoint = sp;
            endPoint = ep;
        }

        public Point getPointFromPoint(Point point, double dist)
        {
            double slope = getSlope();
            if (Math.Abs(slope) > 10000)
            {
                if (slope > 0)
                {
                    Point pt = new Point(point.X, point.Y + (int)dist);
                    return pt;
                }
                else
                {
                    Point pt = new Point(point.X, point.Y - (int)dist);
                    return pt;
                }
            }
            double a = Math.Sqrt((dist * dist) / ((slope * slope) + 1));
            double b = a * slope;
            Point result_pt;
            double direction = dist > 0 ? 1.0 : -1.0;

            a *= direction;
            b *= direction;

            if (slope < 0)
            {
                if (EndPoint.Y > StartPoint.Y)
                {
                    result_pt = new Point((int)(point.X - a), (int)(point.Y - b));
                }
                else
                {
                    result_pt = new Point((int)(point.X + a), (int)(point.Y + b));
                }
            }
            else
            {
                if (EndPoint.Y > StartPoint.Y)
                {
                    result_pt = new Point((int)(point.X + a), (int)(point.Y + b));
                }
                else
                {
                    result_pt = new Point((int)(point.X - a), (int)(point.Y - b));
                }
            }
            return result_pt;
        }

        private double getSlope()
        {
            if (slope < 0.0)
            {
                if (endPoint.X - StartPoint.X == 0)
                {
                    if (endPoint.Y > startPoint.Y)
                        slope = RoomMaker.MAX_SLOPE;
                    else
                        slope = -RoomMaker.MAX_SLOPE;
                }
                else
                    slope = (double)(endPoint.Y - startPoint.Y) / (double)(endPoint.X - StartPoint.X);
            }
            return slope;
        }
    }

    public class Door : Line
    {
        public Door()
        {
            parent_room_id = new List<int>();
        }
        public Door(Point sp, Point ep)
        {
            startPoint = sp;
            endPoint = ep;
            parent_room_id = new List<int>();
        }
        public List<int> parent_room_id;
        public double length;
        public bool isDoor;

    }

    public class Room
    {
        public bool IsStart;
        public Point startPoint;
        public List<Wall> walls;
        public List<Door> doors;
        public List<Door> windows;
        public string type = "Not_defined";
        private int id;

        public int Id { get => id; set => id = value; }

        public Room()
        {
            walls = new List<Wall>();
            doors = new List<Door>();
            windows = new List<Door>();
            IsStart = false;
        }

        public List<Point> getAllCoordinate()
        {

            List<Point> coords = new List<Point>();
            foreach (Wall wall in walls)
            {
                coords.Add(wall.StartPoint);
            }
            return coords;
        }

        public void pushVertex(Point coord)
        {
            if (!IsStart)
            {
                IsStart = true;
                startPoint = coord;
            }
            else
            {
                Wall wall = new Wall(startPoint, coord);
                startPoint = coord;
                walls.Add(wall);
            }
        }

        public void makeClose()
        {
            Wall wall = new Wall(startPoint, walls[0].StartPoint);
            walls.Add(wall);
        }

        public void translateStartPoint(int w, int x, int y)
        {
            walls[w].StartPoint = new Point(x, y);
            if (w == 0)
                walls[walls.Count - 1].EndPoint = new Point(x, y);
            else
                walls[w - 1].EndPoint = new Point(x, y);
        }

        public bool CheckInnerPoint(Point p)
        {
            int LX = -650, RX = 650, UY= 650, DY =-650;
            Line L = new Line(new Point(LX, p.Y), p);
            Line R = new Line(new Point(RX, p.Y), p);
            Line U = new Line(new Point(p.X, UY), p);
            Line D = new Line(new Point(p.X, DY), p);

            int Rc = 0, Lc = 0, Uc = 0, Dc = 0;
            foreach(Wall wall in walls)
            {
                if (Computation.DoIntersect_strict(L, wall))
                    Lc++;
                if (Computation.DoIntersect_strict(R, wall))
                    Rc++;
                if (Computation.DoIntersect_strict(U, wall))
                    Uc++;
                if (Computation.DoIntersect_strict(D, wall))
                    Dc++;
            }
            if (Uc * Dc * Rc * Lc == 0)
                return false;
            //하나라도 0이면 false;
            else if ((Uc % 2) + (Dc % 2) + (Rc % 2) + (Lc % 2) == 4)
            {
                return true;
            }
            // 짝수면 노, 홀수면 ㅇㅇ, 상하좌우 다 홀수.
            else
            {
                return false;
            }
        }

        public List<int> getRectangle()
        {
            int minx = 10000;
            int miny = 10000;
            int maxx = -10000;
            int maxy = -10000;

            for (int  i = 0; i < walls.Count; i++)
            {
                Point sp = walls[i].StartPoint;
                if (minx > sp.X)
                {
                    minx = sp.X;
                }
                if (maxx < sp.X)
                {
                    maxx = sp.X;
                }
                if (miny > sp.Y)
                {
                    miny = sp.Y;
                }
                if (maxy < sp.Y)
                {
                    maxy = sp.Y;
                }
            }

            List<int> result = new List<int>
            {
                minx, miny, maxx-minx, maxy-miny
            };
            return result;
        }


        public void MoveRoom(Point start, Point end)
        {
            int dx = end.X - start.X;
            int dy = end.Y - start.Y;

            foreach (Wall wall in walls)
            {
                wall.StartPoint = new Point(wall.StartPoint.X + dx, wall.StartPoint.Y + dy);
                wall.EndPoint = new Point(wall.EndPoint.X + dx, wall.EndPoint.Y + dy);
            }
        }

        public void resize(int width, int height)
        {
            IsStart = false;
            Point cr = walls[0].StartPoint;
            walls.Clear();
            doors.Clear();
            windows.Clear();

            Point cr1 = new Point(cr.X + width, cr.Y);
            Point cr2 = new Point(cr.X + width, cr.Y + height);
            Point cr3 = new Point(cr.X, cr.Y + height);

            this.pushVertex(cr);
            this.pushVertex(cr1);
            this.pushVertex(cr2);
            this.pushVertex(cr3);
            this.makeClose();
        }
    }

    public struct Furniture
    {
        public Image img;
        public System.Windows.Forms.Label name;
        public Rectangle imgSize;
        public string type;
        public Furniture(Image _img, string _name, Rectangle rect, string _type = "None")
        {
            img = _img;
            name = new System.Windows.Forms.Label();
            name.Text = _name;
            imgSize = new Rectangle();
            imgSize = rect;
            type = _type;
        }
    }

    public class RoomMaker
    {
        static public Room curr_room;
        static public List<Room> rooms;
        static public List<Furniture> furnitures;

        public const double SNAPPING_TRHES = 10.0;
        public const double DOOR_LENGTH_DEFAULT = 20.0;
        public const double MAX_SLOPE = 100000.0;

        static public int room_id = 0;

        static public int PushVertex(ref Point coord, bool snapmode = true)
        {
            if (curr_room.walls.Count > 2 && IsClosed(curr_room, coord))
            {
                curr_room.makeClose();
                if (!IsSimplePolygon(curr_room) || Intersect(rooms, curr_room))
                {
                    Debug.Print("This is Not Simple");
                    curr_room = new Room();
                    return -1;
                }
                rooms.Add(curr_room);
                curr_room = new Room();
                Form_Main.count = rooms.Count;
                return 1;
            }

            Debug.WriteLine(coord.ToString());
            if (snapmode)
            {
                Point new_coord = SnapCoord(coord);
                curr_room.pushVertex(new_coord);
                coord = new_coord;
            }
            else
                curr_room.pushVertex(coord);

            return 0;
        }

        static public int PushRectangle(List<Point> coords, bool snapmode = true)
        {
            curr_room.pushVertex(coords[0]);
            curr_room.pushVertex(coords[1]);
            curr_room.pushVertex(coords[2]);
            curr_room.pushVertex(coords[3]);
            curr_room.makeClose();
            if (snapmode) SnapRectangleRoom(curr_room);
            if (!Intersect(rooms, curr_room))
            {
                rooms.Add(curr_room);
            }
            curr_room = new Room();
            Form_Main.count = rooms.Count;

            return 1;
        }

        static public Door PushDoor(Point center, bool IsDoor = true)
        {
            if (rooms.Count == 0) return null;
            double dist = -1.0;
            Point closest;
            Tuple<int, int> appropriate_wall = FindWallfromDoorCenter(center, out dist, out closest);

            if (dist > SNAPPING_TRHES)
            {
                return null;
            }

            Door new_door = new Door();
            new_door.isDoor = IsDoor;
            new_door.parent_room_id.Add(rooms[appropriate_wall.Item1].Id);
            Wall wall = rooms[appropriate_wall.Item1].walls[appropriate_wall.Item2];

            Debug.WriteLine(wall.StartPoint.ToString() + "," + wall.EndPoint.ToString());
            Debug.WriteLine(closest.ToString());
            if (Computation.EuclideanDist(wall.StartPoint, wall.EndPoint) < DOOR_LENGTH_DEFAULT)
            {
                new_door.StartPoint = wall.StartPoint;
                new_door.EndPoint = wall.EndPoint;
                new_door.length = Computation.EuclideanDist(wall.StartPoint, wall.EndPoint);
            }
            else if (closest.X == wall.StartPoint.X && closest.Y == wall.StartPoint.Y)
            {
                new_door.StartPoint = wall.StartPoint;
                new_door.EndPoint = wall.getPointFromPoint(wall.StartPoint, DOOR_LENGTH_DEFAULT);
                new_door.length = DOOR_LENGTH_DEFAULT;
            }
            else if (closest.X == wall.EndPoint.X && closest.Y == wall.EndPoint.Y)
            {
                new_door.StartPoint = wall.EndPoint;
                new_door.EndPoint = wall.getPointFromPoint(wall.EndPoint, -DOOR_LENGTH_DEFAULT);
                new_door.length = DOOR_LENGTH_DEFAULT;
            }
            else
            {
                new_door.StartPoint = wall.getPointFromPoint(closest, -DOOR_LENGTH_DEFAULT);
                new_door.EndPoint = wall.getPointFromPoint(closest, DOOR_LENGTH_DEFAULT);
                if (!Computation.IsPointInLine(new_door.StartPoint, wall))
                {
                    new_door.StartPoint = wall.StartPoint;
                }
                if (!Computation.IsPointInLine(new_door.EndPoint, wall))
                {
                    new_door.EndPoint = wall.EndPoint;
                }

                new_door.length = Computation.EuclideanDist(new_door.StartPoint, new_door.EndPoint); ;
            }
            if (IsDoor)
                rooms[appropriate_wall.Item1].doors.Add(new_door);
            else
                rooms[appropriate_wall.Item1].windows.Add(new_door);

            return new_door;
        }

        public static bool checkValid()
        {
            foreach (Room room in rooms)
            {
                if (room.doors.Count <= 0)
                    return false;
            }
            if (hasIntersect()) return false;
            return true;
        }

        private static Tuple<int, int> FindWallfromDoorCenter(Point center, out double globalMinDist, out Point closest)
        {
            globalMinDist = 10000.0;
            Tuple<int, int> globalMin = new Tuple<int, int>(-1, -1);
            closest = new Point();
            for (int i = 0; i < rooms.Count; i++)
            {
                for (int j = 0; j < rooms[i].walls.Count; j++)
                {
                    Wall wall = rooms[i].walls[j];
                    Point temp_closest;
                    double dist = Computation.EuclideanDist(wall, center, out temp_closest);
                    if (dist < globalMinDist)
                    {
                        closest = temp_closest;
                        globalMin = new Tuple<int, int>(i, j);
                        globalMinDist = dist;
                    }
                }

            }

            return globalMin;
        }

        internal static void deleteRoom(Room selected_room)
        {
            rooms.Remove(selected_room);
            Form_Main.count = rooms.Count;
            return;
        }

        private static Point SnapCoord(Point point)
        {
            double mindist = 1000.0;
            Point minPoint = new Point(0, 0);
            for (int i = 0; i < rooms.Count; i++)
            {
                for (int j = 0; j < rooms[i].walls.Count; j++)
                {
                    Point rwl = rooms[i].walls[j].StartPoint;

                    double dist = Computation.EuclideanDist(rwl, point);
                    if (mindist > dist)
                    {
                        mindist = dist;
                        minPoint = rwl;
                    }

                }
            }
            if (RoomMaker.SNAPPING_TRHES > mindist)
                return minPoint;
            return point;
        }
        
        public static void SnapRectangleRoom(Room room)
        {
            int n = room.walls.Count;

            if (rooms.Count == 0 || n == 0) return;

            double mindist = 0;
            mindist = 1000.0;
            Point minPoint = new Point(0, 0);
            int mw = -1;
            for (int w = 0; w < n; w += 1)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    for (int j = 0; j < rooms[i].walls.Count; j++)
                    {
                        Point rwl = rooms[i].walls[j].StartPoint;
                            
                        double dist = Computation.EuclideanDist(rwl, room.walls[w].StartPoint);
                        if (mindist > dist)
                        {
                            mindist = dist;
                            minPoint = rwl;
                            mw = w;
                        }

                    }
                }
            }
            if (mw != -1 && mindist < SNAPPING_TRHES)
            {
                mindist = 1000.0;
                room.MoveRoom(room.walls[mw].StartPoint, minPoint);
            }


            return;
        }

        private static bool IsSimplePolygon(Room curr_room)
        {
            for (int i = 0; i < curr_room.walls.Count - 1; i++)
            {
                for (int j = i; j < curr_room.walls.Count; j++)
                {
                    if (Computation.DoIntersect_easy(curr_room.walls[i], curr_room.walls[j]))
                        return false;
                }
            }
            return true;
        }

        public static int CCW(Line line, Point point)
        {
            int x1 = line.StartPoint.X, y1 = line.StartPoint.Y;
            int x2 = line.EndPoint.X, y2 = line.EndPoint.Y;

            int temp = x1 * y2 + x2 * point.Y + point.X * y1;
            temp = temp - y1 * x2 - y2 * point.X - point.Y * x1;

            if (temp > 0)
                return 1;
            else if (temp < 0)
                return -1;
            else
                return 0;
        }

        public static bool hasIntersect()
        {
            for (int i = 0; i < rooms.Count -1; i++)
            {
                for (int j = i; j < rooms.Count; j++)
                {
                    List<Room> rm1 = new List<Room> { rooms[i] };
                    Room rm2 = rooms[j];
                    if (Intersect(rm1, rm2))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool IntersectWall(List<Room> rooms, Room curr_room)
        {
            foreach (Wall curWall in curr_room.walls)
            {
                foreach (Room room in rooms)
                {
                    foreach (Wall wall in room.walls)
                    {
                        if (Computation.DoIntersect_easy(wall, curWall))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private static bool Intersect(List<Room> rooms, Room curr_room)
        {
            //  public List<Wall> walls;
            if (IntersectWall(rooms, curr_room)) return true;
            int ccw, pre = -2;
            foreach (Room room in rooms)
            {
                int i;
                pre = -2;
                for (i = 0; i < curr_room.walls.Count(); i++)
                {
                    ccw = CCW(curr_room.walls[i], room.walls[0].StartPoint);
                    if (pre != -2)
                    {
                        if (ccw != pre)
                        {
                            break;
                        }
                    }
                    pre = ccw;
                }
                if (i == curr_room.walls.Count())
                {
                    return true;
                }
            }
            return false;
        }

        static public int PushFurniture(Furniture ft)
        {
            if (CheckOverlap(ft) || CheckOutside(ft))
            {
                return 1;
            }

            furnitures.Add(ft);
            return 0;
        }

        private static bool CheckOutside(Furniture ft)
        {
            Debug.Print("CheckOutside TODO");
            return false;
        }

        private static void DoSnap(ref Point coord)
        {
            Debug.Print("DoSnap TODO");
            return;
        }

        private static bool IsClosed(Room room, Point coord)
        {
            Point firstCoord = room.walls[0].StartPoint;
            if (Computation.EuclideanDist(firstCoord, coord) < SNAPPING_TRHES)
            {
                return true;
            }
            return false;
        }

        private static bool CheckOverlap(Furniture ft)
        {
            foreach (Room room in rooms)
            {
                if (CheckOverlap(room, ft)) return true;
            }
           
            if (CheckOverlap(furnitures, ft)) return true;
          
            return false;

        }

        private static bool CheckOverlap(List<Furniture> furnitures, Furniture ft)
        {
            int minx = ft.imgSize.X;
            int miny = ft.imgSize.Y;
            int maxx = ft.imgSize.X + ft.imgSize.Width;
            int maxy = ft.imgSize.Y + ft.imgSize.Height;
            List<Line> ft_lines = new List<Line>
            {
                new Line(new Point(minx, miny), new Point(minx, maxy)),
                new Line(new Point(minx, maxy), new Point(maxx, maxy)),
                new Line(new Point(maxx, maxy), new Point(maxx, miny)),
                new Line(new Point(maxx, miny), new Point(minx, miny))
            };

            foreach (Furniture furniture in furnitures)
            {
                int fminx = furniture.imgSize.X;
                int fminy = furniture.imgSize.Y;
                int fmaxx = furniture.imgSize.X + furniture.imgSize.Width;
                int fmaxy = furniture.imgSize.Y + furniture.imgSize.Height;
                List<Line> furniture_lines = new List<Line>
                {
                    new Line(new Point(fminx, fminy), new Point(fminx, fmaxy)),
                    new Line(new Point(fminx, fmaxy), new Point(fmaxx, fmaxy)),
                    new Line(new Point(fmaxx, fmaxy), new Point(fmaxx, fminy)),
                    new Line(new Point(fmaxx, fminy), new Point(fminx, fminy))
                 };
                foreach (Line furniture_line in furniture_lines) {
                    foreach (Line ft_line in ft_lines)
                    {

                        if (Computation.DoIntersect_easy(furniture_line, ft_line))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool CheckOverlap(Room room, Furniture ft)
        {
            int minx = ft.imgSize.X;
            int miny = ft.imgSize.Y;
            int maxx = ft.imgSize.X + ft.imgSize.Width;
            int maxy = ft.imgSize.Y + ft.imgSize.Height;
            List<Line> ft_lines = new List<Line>
            {
                new Line(new Point(minx, miny), new Point(minx, maxy)),
                new Line(new Point(minx, maxy), new Point(maxx, maxy)),
                new Line(new Point(maxx, maxy), new Point(maxx, miny)),
                new Line(new Point(maxx, miny), new Point(minx, miny))
            };

            foreach (Wall wall in room.walls)
            {
                foreach (Line ft_line in ft_lines)
                {
                    if (Computation.DoIntersect_strict(wall, ft_line))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public void WriteFile()
        {
            // Form_Main.Write(rooms);
        }
        public static Room CheckInnerPoint(Point p)
        {
            Room closet = null;
            double closetDis = double.MaxValue;
           
            foreach (Room room in rooms)
            {
                double distance = double.MaxValue, compare;
                if (room.CheckInnerPoint(p))
                {
                    foreach(Wall wall in room.walls)
                    {
                        Point temp = new Point();
                        compare = Computation.EuclideanDist(wall, p, out temp);
                        if (compare < distance)
                            distance = compare;
                    }
                    if(distance < closetDis)
                    {
                        closetDis = distance;
                        closet = room;
                    }
                }
            }
            // 내부 클릭 안하면 null 반환
            return closet;
        }

    }
}
