using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace midas_challenge
{
    using Coordinate = KeyValuePair<int, int>;
    using Line = KeyValuePair<KeyValuePair<int, int>, KeyValuePair<int, int>>;
    public class Wall
    {
        public Line line; // start and end
    }

    public struct Room
    {
        public List<Wall> walls;
        public List<Line> doors;
        public List<Line> windonws;
    }

    public struct Furniture
    {
        public Image img;
        public Label name;
        public Rectangle rectangle;
        public Furniture(Image _img, Label _name, Rectangle rect)
        {
            img = _img;
            name = _name;
            rectangle = rect;
        }
    }

    public class RoomMaker
    {
        static public Room curr_room;
        static public List<Room> rooms;
        static public List<Furniture> furnitures;

        static public int PushVertex(Coordinate coord, bool snapmode = false)
        {
            if (Intersect(rooms, curr_room))
            {

            }

            if (IsClosed(curr_room, coord))
            {
                if (isSimple(curr_room))

                return 1;
            }

            if (snapmode) DoSnap(ref coord);
            

            return 0;
        }

        private static bool isSimple(Room curr_room)
        {
            throw new NotImplementedException();
        }

        private static bool Intersect(List<Room> rooms, Room curr_room)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private static bool IsClosed(Room room, Coordinate coord)
        {
            return false;
        }

        private static bool CheckOverlap(Furniture ft)
        {
            //TODO
            return false;
        }

        public void WriteFile()
        {
           // Form_Main.Write(rooms);
        }
    }
}
