using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace midas_challenge
{
    using Coordinate = KeyValuePair<int, int>;

    partial class Form_Main
    {
       
        public static void Write(List<Room> rooms)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            foreach (Room room in rooms) 
            {
                foreach (Wall wall in room.walls)
                {
                    foreach (Coordinate coord in wall.coords)
                    {

                    }
                }

            }
        }
    }
}
