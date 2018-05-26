using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    public class RoomManager
    {
        private List<Room> rooms;

        public void writeFile()
        {
            IOSystem.write(rooms);
        }
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
