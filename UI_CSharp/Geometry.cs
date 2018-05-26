﻿using System;
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

    public struct Room
    {
        public List<Wall> walls;
        public List<Line> doors;
        public List<Line> windonws;
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
                {

                }

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

    }
}
