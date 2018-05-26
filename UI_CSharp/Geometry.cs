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
        private List<Coordinate> coords;
    }

    public struct Room
    {
        public List<Wall> walls;
        public List<KeyValuePair<Coordinate, Coordinate>> doors;
        public List<KeyValuePair<Coordinate, Coordinate>> windonws;
    }

    public class RoomManager
    {
        public static int pushVertex(Room room, Coordinate coord, bool snapmode)
        {
            if (isClose(room, coord))
            {

            }
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
        private RoomManager room_manager;
        private Room curr_room;
        private List<Room> rooms;

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
