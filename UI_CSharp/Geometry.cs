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
    }

    public class Room
    {
        public bool IsStart;
        public Point startPoint;
        public List<Wall> walls;
        public List<Line> doors;
        public List<Line> windows;
        public Room(){
            walls = new List<Wall>();
            doors = new List<Line>();
            windows = new List<Line>();
            IsStart = false;
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

        public const double SNAPPING_TRHES = 1.0;

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
