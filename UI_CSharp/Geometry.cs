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
        public Line(Point sp, Point ep) {
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
            double direction = dist > 0 ? 1.0 : -1.0 ;

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
                    slope = (double) (endPoint.Y - startPoint.Y) / (double)(endPoint.X - StartPoint.X);
            }
            return slope;
        }
    }

    public class Door : Line
    {
        public Door()
        {

        }
        public Door(Point sp, Point ep)
        {
            startPoint = sp;
            endPoint = ep;
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
        public int id;
        public Room(){
            walls = new List<Wall>();
            doors = new List<Door>();
            windows = new List<Door>();
            IsStart = false;
            id = RoomMaker.room_id++;
        }

        public List<Point> getAllCoordinate() {

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
    }

    public struct Furniture
    {
        public Image img;
        public System.Windows.Forms.Label name;
        public Rectangle imgSize;
        public string type;
        public Furniture(Image _img, string _name, Rectangle rect, string _type="None")
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

        static public int PushVertex(Point coord, bool snapmode = false)
        {
            if (curr_room.walls.Count > 2 && IsClosed(curr_room, coord))
            {
                curr_room.makeClose();
                if (!IsSimplePolygon(curr_room))
                {
                    Debug.Print("This is Not Simple");
                    curr_room = new Room();
                    return -1;
                }
                rooms.Add(curr_room);
                curr_room = new Room();
                return 1;
            }

            if (snapmode) DoSnap(ref coord);
            if (Intersect(rooms, curr_room))
            {

            }

            curr_room.pushVertex(coord);


            return 0;
        }

        static public int PushRectangle(List<Point> coords, bool snapmode = false)
        {
            curr_room.pushVertex(coords[0]);
            curr_room.pushVertex(coords[1]);
            curr_room.pushVertex(coords[2]);
            curr_room.pushVertex(coords[3]);
            curr_room.makeClose();
            if (snapmode) DoSnapCurrentRoom();

            rooms.Add(curr_room);
            curr_room = new Room();
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
               // return null;
            }

            Door new_door = new Door();
            new_door.isDoor = IsDoor;
            new_door.parent_room_id.Add(rooms[appropriate_wall.Item1].id);
            Wall wall = rooms[appropriate_wall.Item1].walls[appropriate_wall.Item2];

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
        
        private static Tuple<int, int> FindWallfromDoorCenter(Point center, out double globalMinDist, out Point closest)
        {
            globalMinDist = 10000.0;
            Tuple<int, int> globalMin = new Tuple<int, int>(-1, -1);
            closest = new Point();
            for (int i = 0; i < rooms.Count; i++)
            {
                //Tuple<Room, int> localMin = new Tuple<Room, int>(rooms[i], 0);
                // double localMinDist = 10000.0;
                for (int j = 0; j < rooms[i].walls.Count; j++)
                {
                    Wall wall = rooms[i].walls[j];
                    double dist = Computation.EuclideanDist(wall, center, out closest);
                    if (dist < globalMinDist)
                    {
                        globalMin = new Tuple<int, int>(i,j);
                        globalMinDist = dist;
                    }
                }
                    
            }

            return globalMin;
        }
        
        private static void DoSnapCurrentRoom()
        {
            Debug.Print("Intersect TODO");
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

        private static bool Intersect(List<Room> rooms, Room curr_room)
        {
            Debug.Print("Intersect TODO");
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
    }

}
