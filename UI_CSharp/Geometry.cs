using System;
using System.Collections.Generic;
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
        public Furniture(Image _img, string _name, Rectangle rect)
        {
            img = _img;
            name = new System.Windows.Forms.Label();
            name.Text = _name;
            imgSize = new Rectangle();
            imgSize = rect;
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
            
            if (Intersect(rooms, curr_room))
            {

            }

            if (curr_room.walls.Count > 2 && IsClosed(curr_room, coord))
            {
                curr_room.makeClose();
                if (isSimple(curr_room))
                {

                }
                rooms.Add(curr_room);
                curr_room = new Room();
                return 1;
            }

            if (snapmode) DoSnap(ref coord);
            curr_room.pushVertex(coord);


            return 0;
        }

        private static bool isSimple(Room curr_room)
        {
            for (int i = 0; i < curr_room.walls.Count - 1; i++)
            {
                for (int j = i; j < curr_room.walls.Count; j++)
                {
                    
                }
            }
            return true;
        }

        private static bool Intersect(List<Room> rooms, Room curr_room)
        {
            Console.Write("TODO");
            return false;
        }

        static public int PushFurniture(Furniture ft)
        {
            if (CheckOverlap(ft))
            {
                return 1;
            }
            
            furnitures.Add(ft);
            return 0;
        }

        private static void DoSnap(ref Point coord)
        {
            Console.Write("TODO");
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
