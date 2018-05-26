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

    public class RoomManager
    {
        public static int PushVertex(Room room, ref Coordinate coord, bool snapmode)
        {

            if (IsClose(room, coord))
            {


            }

            if (snapmode) DoSnap(ref coord, );

            return 0;
        }

        private static void DoSnap(ref Coordinate coord)
        {
            throw new NotImplementedException();
        }

        public static bool IsClose(Room room, Coordinate coord)
        {
            return false;
        }

        public static bool CheckOverlap(Furniture ft, List<Room> rooms)
        {
            //TODO
            return false;
        }
    }

    public struct Furniture
    {
        public Coordinate lowerLeft;
        public Coordinate upperRight;
        public Image img;
        public Label name;
        public Rectangle rectangle;
    }

    public class RoomMaker
    {
        public Room curr_room;
        static public List<Room> rooms;
        static public List<Furniture> furnitures;

        static public int PushVertex(Coordinate cd, bool snapmode = false)
        {
            return 0;
        }

        static public int PushFurniture(Furniture ft)
        {
            /*
            if (RoomManager.CheckOverlap(ft, rooms))
            {
                return 1;
            }
            */
            furnitures.Add(ft);
            return 0;
        }

        public void WriteFile()
        {
           // Form_Main.Write(rooms);
        }
    }
}
