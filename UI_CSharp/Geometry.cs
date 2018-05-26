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

    public class Wall
    {
        public List<Coordinate> coords;
    }

    public struct Room
    {
        public List<Wall> walls;
        public List<KeyValuePair<Coordinate, Coordinate>> doors;
        public List<KeyValuePair<Coordinate, Coordinate>> windonws;
    }

    public struct Furniture
    {
        public Coordinate lowerLeft;
        public Coordinate upperRight;
        public Image img;
        public Label name;
        public Rectangle rectangle;
        public Furniture(Coordinate ll, Coordinate ur, Image _img, Label _name, Rectangle rect)
        {
            lowerLeft = ll;
            upperRight = ur;
            img = _img;
            name = _name;
            rectangle = rect;
        }
    }

    public class RoomMaker
    {
        public Room curr_room;
        static public List<Room> rooms;
        static public List<Furniture> furnitures;

        static public int PushVertex(Coordinate cd, bool snapmode = false)
        {
            if (IsClose(room, coord))
            {


            }

            if (snapmode) DoSnap(ref coord);

            return 0;
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

        private static bool IsClose(Room room, Coordinate coord)
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
