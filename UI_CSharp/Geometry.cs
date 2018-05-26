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
    using Coordinate = KeyValuePair<int, int>;
    using Line = KeyValuePair<KeyValuePair<int, int>, KeyValuePair<int, int>>;
    public class Wall
    {
        private Line line; // start and end

        public Line Line { get => line; set => line = value; }
    }

    public class Room
    {
        public bool IsStart;
        public Coordinate startPoint;
        public List<Wall> walls;
        public List<Line> doors;
        public List<Line> windows;
        public Room(){
            walls = new List<Wall>();
            doors = new List<Line>();
            windows = new List<Line>();
            IsStart = false;
        }

        public void pushVertex(Coordinate coord)
        {
            if (!IsStart)
            {
                IsStart = true;
                startPoint = coord;
            }
            else
            {
                Wall wall = new Wall();
                wall.Line = new Line(startPoint, coord);
                walls.Add(wall);
            }
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

        static public int PushVertex(Coordinate coord, bool snapmode = false)
        {
            
            if (Intersect(rooms, curr_room))
            {

            }

            if (curr_room.walls.Count > 2 && IsClosed(curr_room, coord))
            {
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
            Console.Write("TODO");
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

        private static void DoSnap(ref Coordinate coord)
        {
            Console.Write("TODO");
            return;
        }

        private static bool IsClosed(Room room, Coordinate coord)
        {
            Coordinate firstCoord = room.walls[0].Line.Key;
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
                new Line(new Coordinate(minx, miny), new Coordinate(minx, maxy)),
                new Line(new Coordinate(minx, maxy), new Coordinate(maxx, maxy)),
                new Line(new Coordinate(maxx, maxy), new Coordinate(maxx, miny)),
                new Line(new Coordinate(maxx, miny), new Coordinate(minx, miny))
            };
               
            foreach (Wall wall in room.walls)
            {
                foreach (Line ft_line in ft_lines)
                {
                    if (Computation.DoIntersect(wall.Line, ft_line))
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

    public class Computation
    {
        public static bool DoIntersect(Line line1, Line line2)
        {
            return CrossProduct(line1.Key, line1.Value, line2.Key) !=
                   CrossProduct(line1.Key, line1.Value, line2.Value) ||
                   CrossProduct(line2.Key, line2.Value, line1.Key) !=
                   CrossProduct(line2.Key, line2.Value, line1.Value);
        }
        public static double CrossProduct(Coordinate p1, Coordinate p2, Coordinate p3)
        {
            return (double)(p2.Key - p1.Key) * (double)(p3.Value - p1.Value) - (double)(p3.Key - p1.Key) * (double)(p2.Value - p1.Value);
        }
        public static double EuclideanDist(KeyValuePair<int, int> coord1, KeyValuePair<int, int> coord2)
        {
            return Math.Sqrt(Math.Pow((double)(coord1.Key - coord2.Key), 2.0) + Math.Pow((double)(coord2.Value - coord1.Value), 2.0));
        }

    }
}
