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
        private List<Room> rooms;

        public void writeFile()
        {
            //IOSystem.write(rooms);
        }
    }

    public class Furniture
    {
        private Coordinate lowerLeft;
        private Coordinate upperRight;
        private Image img;
        private Label name;
    }

    public class RoomMaker
    {
        private RoomManager room_manager;
        private Room curr_room;
        public int pushVertex(Coordinate cd)
        {

            return 0;
        }
    }
}
