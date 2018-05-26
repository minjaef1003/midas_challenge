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
        private Panel panel_canvas;
        private int menu_width;
        //isCreateMenu : 0:선택x, 1:room, 2:furniture
        private int isCreateMenu = 0;
        private bool isRect = false, isPolygon = false, isDraw = false;
        private Point sp, ep; // start point, end point;
        private Rectangle rect;

        public Form_Main()
        {
            InitializeComponent();
            menu_width = panel_createroom_menu.Width;
            panel_createroom_menu.Width = 0;
            panel_furniture_menu.Width = 0;


        }
        private void button_new_document_Click(object sender, EventArgs e)
        {
            panel_canvas = new Panel();
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
            if (isRect)
            {
                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
            else if (isPolygon)
            {
                Pen pen = new Pen(Color.Black, 3);
                e.Graphics.DrawLine(pen, sp, ep);
            }
        }

        private void panel_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            isDraw = true;
        }
        private void panel_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                if (isRect)
                {
                    int width = e.X - sp.X;
                    int height = e.Y - sp.Y;
                    rect = new Rectangle(sp.X, sp.Y, width, height);
                    panel_canvas.Refresh();

                }
                else if (isPolygon)
                {
                    ep = e.Location;
                    panel_canvas.Refresh();
                }
            }
        }
        private void panel_canvas_MouseUp(object sender, MouseEventArgs e)
        {
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
    }
}
