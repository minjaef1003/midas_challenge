﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midas_challenge
{
    public partial class Form_Main : Form
    {
        public static int count = 0;
        public static Tuple<int, int> history;
        private List<Rectangle> rectList;
        private DoubleBufferPannel panel_canvas;
        private int menu_width, width, height;
        //isCreateMenu : 1:room 2:furniture
        private int isCreateMenu = 0;
        private bool isRect = false, isPolygon = false,
            isDraw = false, isLine = false,
            isWindow = false, isDoor = false;
        private Point sp, ep, loc; // start point, end point;
        private Rectangle rect;
        private int selectFurn = 0;
        Furniture f;
        Image imgDoor, imgWindow;
        Point[] pointList;
        int cnt = 0;
        public Form_Main()
        {
            InitializeComponent();
            InitImgFurnitureDic();
            InitFurnitureRoom();
            menu_width = panel_createroom_menu.Width;
            panel_createroom_menu.Width = 0;
            panel_furniture_menu.Width = 0;
            rectList = new List<Rectangle>();
            history = new Tuple<int, int>(0, 0);
            RoomMaker.curr_room = new Room();
            RoomMaker.rooms = new List<Room>();
            RoomMaker.furnitures = new List<Furniture>();
            imgDoor = Image.FromFile("res/icons8_Door_40px.png");
            imgWindow = Image.FromFile("res/icons8_Open_Window_40px.png");
        }
        private void button_new_document_Click(object sender, EventArgs e)
        {
            panel_canvas = new DoubleBufferPannel();
            panel_canvas.ResumeLayout(false);
            panel_canvas.SuspendLayout();
            panel_canvas.BorderStyle = BorderStyle.FixedSingle;
            panel_canvas.Dock = DockStyle.Fill;
            panel_canvas.Name = "panel_canvas";
            panel_canvas.Size = new Size(876, 555);
            panel_canvas.BackColor = Color.FromArgb(255, 255, 255, 253);
            panel_canvas.Paint += new PaintEventHandler(this.panel_canvas_Paint);
            panel_canvas.MouseDown += new MouseEventHandler(this.panel_canvas_MouseDown);
            panel_canvas.MouseMove += new MouseEventHandler(this.panel_canvas_MouseMove);
            panel_canvas.MouseUp += new MouseEventHandler(this.panel_canvas_MouseUp);
            panel_workspace.Controls.Add(panel_canvas);
            panel_workspace.Refresh();
        }
        private void panel_canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < RoomMaker.curr_room.walls.Count; i++)
            {
                e.Graphics.DrawLine(pen, RoomMaker.curr_room.walls[i].StartPoint, RoomMaker.curr_room.walls[i].EndPoint);
            }
            cnt = 0;
            for (int i = 0; i < Form_Main.count; i++)
            {
                int size = RoomMaker.rooms[i].walls.Count;
                pointList = new Point[size];
                for (int j = 0; j < RoomMaker.rooms[i].walls.Count; j++)
                {
                    Point[] p =
                    {
                        RoomMaker.rooms[i].walls[j].StartPoint,
                        RoomMaker.rooms[i].walls[j].EndPoint
                    };

                    pointList[cnt++] = p[0];
                    pointList[cnt++] = p[1];
                    if (cnt == RoomMaker.rooms[i].walls.Count)
                    {
                        HatchStyle h = (HatchStyle)3;
                        HatchBrush hatch = new HatchBrush(h, Color.SkyBlue, Color.White);
                        e.Graphics.FillPolygon(hatch, pointList);
                        cnt = 0;
                    }

                    e.Graphics.DrawPolygon(pen, p);
                }


            }
            for (int i = 0; i < RoomMaker.furnitures.Count; i++)
            {
                var furn = RoomMaker.furnitures[i];
                e.Graphics.DrawImage(furn.img, furn.imgSize.X,
                    furn.imgSize.Y, furn.imgSize.Width, furn.imgSize.Height);

                e.Graphics.DrawString(furn.name.Text, Font, Brushes.Black,
                    (furn.imgSize.Width + (2 * furn.imgSize.X)) / 2 - 15,
                    furn.imgSize.Y + furn.imgSize.Height);
            }
            for (int i = 0; i < RoomMaker.rooms.Count; i++)
            {
                Pen pen1 = new Pen(Color.Black, 9);
                for (int j = 0; j < RoomMaker.rooms[i].doors.Count; j++)
                {
                    var doors = RoomMaker.rooms[i].doors;
                    pen1.Color = Color.Black;
                    e.Graphics.DrawLine(pen1, doors[j].StartPoint, doors[j].EndPoint);

                }
                for (int j = 0; j < RoomMaker.rooms[i].windows.Count; j++)
                {
                    var windows = RoomMaker.rooms[i].windows;
                    pen1.Color = Color.Red;
                    e.Graphics.DrawLine(pen1, windows[j].StartPoint, windows[j].EndPoint);

                }
            }
            if (isRect)
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
            else if (isPolygon && isLine)
            {
                e.Graphics.DrawLine(pen, sp, loc);
            }

            if (selectFurn != 0)
            {
                e.Graphics.DrawImage(f.img, loc.X, loc.Y, width, height);
            }

            if (isDoor)
            {
                e.Graphics.DrawImage(imgDoor, loc.X, loc.Y);
            }
            if (isWindow)
            {
                e.Graphics.DrawImage(imgWindow, loc.X, loc.Y);
            }
        }

        private void panel_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectFurn != 0)
            {
                label_status.Text = "furniture를 선택함";
                Room room = RoomMaker.CheckInnerPoint(new Point(e.X, e.Y));
                if (room != null) {
                    f.imgSize.X = e.X; f.imgSize.Y = e.Y;
                    if (RoomMaker.PushFurniture(f) == 1)
                        selectFurn = 0;
                }
            }
            if (isDoor)
            {
                RoomMaker.PushDoor(new Point(e.X, e.Y), true);
                isRect = false;
                isPolygon = false;
                label_status.Text = "door를 선택함";
            }
            if (isWindow)
            {
                RoomMaker.PushDoor(new Point(e.X, e.Y), false);
                isRect = false;
                isPolygon = false;
                label_status.Text = "window를 선택함";
            }

            if (isPolygon)
            {
                label_status.Text = "polygon을 선택함";
                if (!isLine)
                {
                    sp = e.Location;
                    ep = e.Location;
                    isLine = true;
                    RoomMaker.PushVertex(ref sp);
                }
                else
                {
                    ep = e.Location;
                    if (RoomMaker.PushVertex(ref ep) == 1)
                    {
                        isPolygon = false;
                        isLine = false;
                    }
                    sp = ep;
                }
            }
            else
            {
                sp = e.Location;
            }

            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(new Point(MousePosition.X, MousePosition.Y));

            isDraw = true;
        }
        private void panel_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            loc = e.Location;
            if (isDraw)
            {
                if (isRect)
                {
                    int width = e.X - sp.X;
                    int height = e.Y - sp.Y;
                    rect = new Rectangle(sp.X, sp.Y, width, height);
                }
                else if (isPolygon)
                {
                    //ep = e.Location;                    
                }
            }
            panel_canvas.Refresh();
        }
        private void panel_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isRect)
            {
                List<Point> list = new List<Point>();
                list.Add(new Point(rect.X + rect.Width, rect.Y));
                list.Add(new Point(rect.X + rect.Width, rect.Y + rect.Height));
                list.Add(new Point(rect.X, rect.Y + rect.Height));
                list.Add(new Point(rect.X, rect.Y));

                RoomMaker.PushRectangle(list);

                isRect = false;
                rect = new Rectangle(0, 0, 0, 0);
            }
            isDraw = false;
        }
        private void button_create_room_Click(object sender, EventArgs e)
        {
            if (isCreateMenu == 1)
            {
                isCreateMenu = 0;
                panel_createroom_menu.Width = 0;
            }
            else
            {
                isCreateMenu = 1;
                timer_menu_slide.Start();
            }
        }

        private void button_create_furniture_Click(object sender, EventArgs e)
        {
            isRect = false;
            if (isCreateMenu == 2)
            {
                selectFurn = 0;
                isCreateMenu = 0;
                panel_furniture_menu.Width = 0;
            }
            else
            {
                isCreateMenu = 2;
                timer_menu_slide.Start();
            }
        }

        private void timer_menu_slide_Tick(object sender, EventArgs e)
        {
            if (isCreateMenu == 1 && panel_createroom_menu.Width <= menu_width)
            {
                panel_createroom_menu.Width += 4;
            }
            else if (isCreateMenu == 1 && panel_createroom_menu.Width > menu_width)
            {
                timer_menu_slide.Stop();
            }
            if (isCreateMenu == 2 && panel_furniture_menu.Width <= menu_width)
            {
                panel_furniture_menu.Width += 4;
            }
            else if (isCreateMenu == 2 && panel_furniture_menu.Width > menu_width)
            {
                timer_menu_slide.Stop();
            }
        }

        private void button_createroom_line_Click(object sender, EventArgs e)
        {
            isPolygon = true; isRect = false;
        }

        private void button_create_door_Click(object sender, EventArgs e)
        {
            if (isDoor) isDoor = false;
            else isDoor = true;
        }

        private void button_create_window_Click(object sender, EventArgs e)
        {
            if (isWindow) isWindow = false;
            else isWindow = true;
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string openFileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;                
            }
            else if (result == DialogResult.Cancel) return;

            button_new_document_Click(sender, e);
           
            Tuple<List<Room>, List<Furniture>> readDate;
            readDate = Read(openFileName);
            RoomMaker.rooms = readDate.Item1;
            RoomMaker.furnitures = readDate.Item2;
            Form_Main.count = RoomMaker.rooms.Count;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Write(RoomMaker.rooms, RoomMaker.furnitures,saveFileDialog1.FileName);
            }
        }

        private void button_save_image_Click(object sender, EventArgs e)
        {         
            Bitmap bmp = new Bitmap(panel_canvas.Width, panel_canvas.Height);
            panel_canvas.DrawToBitmap(bmp, new Rectangle(0, 0, panel_canvas.Width, panel_canvas.Height));        
            saveFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int idx = saveFileDialog1.FilterIndex;
                if (idx == 1) bmp.Save(saveFileDialog1.FileName, ImageFormat.Png);
                else bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void button_createroom_rect_Click(object sender, EventArgs e)
        {
            isRect = true; isPolygon = false;
        }

        private void select_furniture(Image img, string type)
        {
            selectFurn = 1;
            FurnitureCreate fc = new FurnitureCreate();
            if (fc.ShowDialog() == DialogResult.Cancel)
            {
                width = fc.width;
                height = fc.height;
                f = new Furniture(img, fc.name, new Rectangle(0, 0, fc.width, fc.height), type);
            }
        }
        private void button_fur_table_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Table_100px;
            select_furniture(img, "Table");
        }

        private void button_fur_toilet_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Toilet_Bowl_96px;
            select_furniture(img, "Toilet_Bowl");
        }

        private void button_fur_bureau_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Bureau_100px;
            select_furniture(img, "Bureau");
        }

        private void button_fur_washing_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Washing_Machine_100px_1;
            select_furniture(img, "Washing_Machine");
        }

        private void button_fur_lamp_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Lamp_100px;
            select_furniture(img, "Lamp");
        }

        private void button_fur_closet_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Closet_100px;
            select_furniture(img, "Closet");
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            if (Form_Main.count > 0)
            {
                Form_Main.count--;
                panel_canvas.Refresh();
            }
        }

        private void button_redo_Click(object sender, EventArgs e)
        {
            if (Form_Main.count < RoomMaker.rooms.Count)
            {
                Form_Main.count++;
                panel_canvas.Refresh();
            }
        }
    }
}
