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

        public static Dictionary<string, Image> imgDic = new Dictionary<string, Image>();
        public static void AddImg(string str, Image img)
        {
            imgDic.Add(str, img);
        }
        public static void InitImgDic()
        {
            AddImg("Table", Properties.Resources.icons8_Table_100px);
            AddImg("Toilet_Bowl", Properties.Resources.icons8_Toilet_Bowl_96px);
            AddImg("Bureau", Properties.Resources.icons8_Bureau_100px);
            AddImg("Washing_Machine", Properties.Resources.icons8_Washing_Machine_100px_1);
            AddImg("Lamp", Properties.Resources.icons8_Lamp_100px);
            AddImg("Closet", Properties.Resources.icons8_Closet_100px);
            AddImg("None", Properties.Resources.icons8_None_800px);
        }

        public static Tuple<List<Room>, List<Furniture>> Read(string fileName)
        {
            List<Room> rooms = new List<Room>();
            List<Furniture> furnitures = new List<Furniture>();

            int roomCount = 0, furnitureCount = 0;
            string line;
            string[] str;
            StreamReader sr = new StreamReader(fileName);

            if ((line = sr.ReadLine()) != null)
            {
                str = line.Split(' ');
                roomCount = Int32.Parse(str[2]);
            }

            for (int i = 0; i < roomCount; i++)
            {
                rooms.Add(new Room());
                while (((line = sr.ReadLine()) != null))
                {
                    str = line.Split(' ', ',', '{', 'X', '=', 'Y', '}');
                    if (str[0].Equals("Wall"))
                    {
                        rooms[i].walls.Add(new Wall(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else if (str[0].Equals("Door"))
                    {
                        rooms[i].doors.Add(new Line(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else if (str[0].Equals("Window"))
                    {
                        rooms[i].windows.Add(new Line(new Point(Int32.Parse(str[1]), Int32.Parse(str[2])), new Point(Int32.Parse(str[3]), Int32.Parse(str[4]))));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if ((line = sr.ReadLine()) != null)
            {
                str = line.Split(' ');
                furnitureCount = Int32.Parse(str[2]);
            }


            for (int i = 0; i < furnitureCount; i++)
            {
                furnitures.Add(new Furniture());
                if (((line = sr.ReadLine()) != null))
                {
                    str = line.Split(' ', ',');

                    furnitures[i] = new Furniture(imgDic[str[2]], str[1], new Rectangle(Int32.Parse(str[3]), Int32.Parse(str[4]), Int32.Parse(str[5]), Int32.Parse(str[6])), str[2]);
                }
            }

            return new Tuple<List<Room>, List<Furniture>>(rooms, furnitures);
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
                    str = "Wall " + wall.StartPoint.X + " " + wall.StartPoint.Y + " " + wall.EndPoint.X + " " + wall.EndPoint.Y;
                    sw.WriteLine(str);
                }
                foreach (Line door in room.doors)
                {
                    str = "Door " + door.StartPoint.X + " " + door.StartPoint.Y + " " + door.EndPoint.X + " " + door.EndPoint.Y;
                    sw.WriteLine(str);
                }
                foreach (Line window in room.windows)
                {
                    str = "Window " + window.StartPoint.X + " " + window.StartPoint.Y + " " + window.EndPoint.X + " " + window.EndPoint.Y;
                    sw.WriteLine(str);
                }
                sw.WriteLine("Room " + i.ToString() + " finish");
            }
            sw.WriteLine("Furniture count: " + furnitures.Count());
            foreach (Furniture furniture in furnitures)
            {
                str = "Funiture " + furniture.name.Text + " " + furniture.type + " " + furniture.imgSize.X + " " + furniture.imgSize.Y + " " + furniture.imgSize.Width + " " + furniture.imgSize.Height;
                sw.WriteLine(str);
            }

            sw.Close();
        }
    }
}
