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
        public Form_Main()
        {
            InitializeComponent();
 
        }
        private void button_new_document_Click(object sender, EventArgs e)
        {
            panel_canvas = new Panel();
            panel_canvas.ResumeLayout(false);
            panel_canvas.SuspendLayout();
            panel_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_canvas.Location = new System.Drawing.Point(213, 0);
            panel_canvas.Name = "panel_canvas";
            panel_canvas.Size = new System.Drawing.Size(876, 555);
            panel_canvas.BackColor = Color.White;
            this.Controls.Add(panel_canvas);
            panel_canvas.Show();
        }
        private void button_create_room_Click(object sender, EventArgs e)
        {

        }

    }
}
