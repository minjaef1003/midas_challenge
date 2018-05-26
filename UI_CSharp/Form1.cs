using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private bool isCreateMenu = false;
        public Form_Main()
        {
            InitializeComponent();
            menu_width = panel_createroom_menu.Width;
            panel_createroom_menu.Width = 0;
 
        }
        private void button_new_document_Click(object sender, EventArgs e)
        {
            panel_canvas = new Panel();
            panel_canvas.ResumeLayout(false);
            panel_canvas.SuspendLayout();
            panel_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_canvas.Name = "panel_canvas";
            panel_canvas.Size = new System.Drawing.Size(876, 555);
            panel_canvas.BackColor = Color.White;
            panel_workspace.Controls.Add(panel_canvas);
            panel_workspace.Refresh();
        }
        private void button_create_room_Click(object sender, EventArgs e)
        {
            isCreateMenu = false;
            timer_menu_slide.Start();
        }

        private void timer_menu_slide_Tick(object sender, EventArgs e)
        {
            if(isCreateMenu == false)
            {
                if (panel_createroom_menu.Width <= menu_width)
                {
                    panel_createroom_menu.Width += 4;
                }
                else
                {                  
                    timer_menu_slide.Stop();
                }
            }
            else
            {
                if(panel_createroom_menu.Width >= 0)
                {
                    panel_createroom_menu.Width -= 4;
                }
                else
                {
                    timer_menu_slide.Stop();
                }
            }
            
        }

        private void button_createroom_line_Click(object sender, EventArgs e)
        {
            isCreateMenu = true;
            timer_menu_slide.Start();
        }

        private void button_createroom_rect_Click(object sender, EventArgs e)
        {
            isCreateMenu = true;
            timer_menu_slide.Start();
        }
    }
}
