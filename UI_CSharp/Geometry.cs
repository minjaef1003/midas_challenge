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
        public static int pushVertex(Room room, ref Coordinate coord, bool snapmode)
        {
            if (isClose(room, coord))
            {


            }

            //snapmode(coord);

            return 0;
        }

        public static bool isClose(Room room, Coordinate coord)
        {
            return 0;
        }
    }

    public class Furniture
    {
        public Coordinate lowerLeft;
        public Coordinate upperRight;
        public Image img;
        public Label name;
    }

    public class RoomMaker
    {
        public RoomManager room_manager;
        public Room curr_room;
        public List<Room> rooms;

        public int pushVertex(Coordinate cd, bool snapmode = false)
        {
             return RoomManager.pushVertex(curr_room, cd, snapmode);
        }

        public void writeFile()
        {
            Form_Main.write(rooms);
        }
    }
}
