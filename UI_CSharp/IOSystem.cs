using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midas_challenge
{
    partial class Form_Main
    {
        public static Tuple<List<Room>, List<Furniture>> Read()
        {
            List<Room> rooms;
            List<Furniture> furnitures;

            int roomCount = 0, furnitureCount = 0;
            string line;
            StreamReader sr = new StreamReader("test.txt");

            if ((line = sr.ReadLine()) != null) {
                roomCount = Int32.Parse(line);
            }

            rooms = new List<Room>(roomCount);

            for (int i = 0; i < roomCount; i++)
            {
                while (((line = sr.ReadLine()) != null))
                {
                    string[] str = line.Split(' ', ',');
                    if (str[0].Equals("Wall"))
                    {
                        rooms[i].walls.Add(new Wall(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else if (str[0].Equals("Door"))
                    {
                        rooms[i].doors.Add(new Wall(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else if (str[0].Equals("Window"))
                    {
                        rooms[i].windows.Add(new Wall(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if ((line = sr.ReadLine()) != null)
            {
                furnitureCount = Int32.Parse(line);
            }

            furnitures = new List<Furniture>(furnitureCount);

            for (int i = 0; i < furnitureCount; i++)
            {
                if (((line = sr.ReadLine()) != null))
                {
                    string[] str = line.Split(' ', ',');

                    furnitures[i].name = str[1];
                    furnitures[i].type = str[2];

                    str = "Funiture " + funiture.name.ToString() + " " + furnitures.type.ToSting() + " " + funiture.imgSize.X + " " + funiture.imgSize.Y + " " + funiture.imgSize.Width + " " + funiture.imgSize.Height;
                }
            }

            Tuple<List<Room>, List<Furniture>> result;

            return result;
        }
        public static void Write(List<Room> rooms, List<Furniture> furnitures)
        {
            StreamWriter sw = new StreamWriter("test.txt");
            string str;
            int i = 0;
            sw.WriteLine("Rooms count: " + rooms.Count());
            foreach (Room room in rooms)
            {
                i++;
                str = "Room " + i.ToString();
                foreach (Wall wall in room.walls)
                {
                    str = "Wall " + wall.StartPoint.ToString() + " " + wall.EndPoint.ToString();
                    sw.WriteLine(str);
                }
                foreach (Line door in room.doors)
                {
                    str = "Door " + door.StartPoint.ToString() + " " + door.EndPoint.ToString();
                    sw.WriteLine(str);
                }
                foreach (Line window in room.windows)
                {
                    str = "Window " + window.StartPoint.ToString() + " " + window.EndPoint.ToString();
                    sw.WriteLine(str);
                }
                sw.WriteLine("Room " + i.ToString() + "finish");
            }
            sw.WriteLine("Furniture count: " + furnitures.Count());
            foreach (Furniture funiture in furnitures)
            {
                str = "Funiture " + funiture.name.ToString() + " " + furnitures.type.ToSting() + " " + funiture.imgSize.X + " " + funiture.imgSize.Y + " " + funiture.imgSize.Width + " " + funiture.imgSize.Height;
                sw.WriteLine(str);
            }
            sw.Close();
        }
    }
}
