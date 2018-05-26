using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midas_challenge
{
    public partial class Form_Main : Form
    {
        private List<Rectangle> rectList;
        private DoubleBufferPannel panel_canvas;
        private int menu_width;
        //isCreateMenu : 1:room 2:furniture
        private int isCreateMenu = 0;
        private bool isRect = false, isPolygon = false, 
            isDraw = false, isLine = false;
        private Point sp, ep, loc; // start point, end point;
        private Rectangle rect;
        private int selectFurn = 0;
        Furniture f;

        public Form_Main()
        {
            InitializeComponent();
            menu_width = panel_createroom_menu.Width;
            panel_createroom_menu.Width = 0;
            panel_furniture_menu.Width = 0;
            rectList = new List<Rectangle>();
            RoomMaker.curr_room = new Room();
            RoomMaker.rooms = new List<Room>();
            RoomMaker.furnitures = new List<Furniture>();            
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
            panel_canvas.BackColor = Color.White;
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
            for (int i=0; i<RoomMaker.rooms.Count(); i++)
            {
                e.Graphics.DrawRectangle(pen, rectList[i]);
            }
            if (isRect)
            {                
                e.Graphics.DrawRectangle(pen, rect);
            }
            else if (isPolygon && isLine)
            {             
                e.Graphics.DrawLine(pen, sp, ep);
            }

            if(selectFurn != 0)
            {
                e.Graphics.DrawImage(f.img, loc.X-50, loc.Y-50);
            }
        }

        private void panel_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            f.imgSize.X = e.X; f.imgSize.Y = e.Y;
            if(RoomMaker.PushFurniture(f) == 1)
                selectFurn = 0;
            
           
            if (isPolygon)
            {
                if (!isLine)
                {
                    sp = e.Location;
                    ep = e.Location;
                    isLine = true;
                }
                else
                {
                    sp = ep;
                    ep = e.Location;
                }
            }
            else
            {
                sp = e.Location;
            }
            
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
            if(isRect)
            {
                KeyValuePair<int, int> p = new KeyValuePair<int, int>(rect.X, rect.Y);
                RoomMaker.PushVertex(p);
                p = new KeyValuePair<int, int>(rect.X + rect.Width, rect.Y);
                RoomMaker.PushVertex(p);
                p = new KeyValuePair<int, int>(rect.X + rect.Width, rect.Y + rect.Height);
                RoomMaker.PushVertex(p);
                p = new KeyValuePair<int, int>(rect.X, rect.Y + rect.Height);
                RoomMaker.PushVertex(p);
                p = new KeyValuePair<int, int>(rect.X, rect.Y);
                if(RoomMaker.PushVertex(p) == 1)
                {

                }
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

        private void button_createroom_rect_Click(object sender, EventArgs e)
        {
            isRect = true; isPolygon = false;
        }

        private void select_furniture(Image img)
        {
            selectFurn = 1;
            FurnitureCreate fc = new FurnitureCreate();
            if (fc.ShowDialog() == DialogResult.Cancel)
            {
                f = new Furniture(img, fc.name, new Rectangle(0, 0, fc.width, fc.height));                
            }
        }
        private void button_fur_table_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Table_100px;
            select_furniture(img);
        }

        private void button_fur_toilet_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Toilet_Bowl_96px;
            select_furniture(img);
        }

        private void button_fur_bureau_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Bureau_100px;
            select_furniture(img);
        }

        private void button_fur_washing_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Washing_Machine_100px_1;
            select_furniture(img);
        }

        private void button_fur_lamp_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Lamp_100px;
            select_furniture(img);
        }

        private void button_fur_closet_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_Closet_100px;
            select_furniture(img);
        }
    }
}
