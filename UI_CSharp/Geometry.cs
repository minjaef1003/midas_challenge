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
