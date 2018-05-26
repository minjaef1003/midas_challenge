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
    public partial class FurnitureCreate : Form
    {
        public int width, height;
        public string name;

        public FurnitureCreate()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            width = int.Parse(textbox_width.Text);
            height = int.Parse(textbox_height.Text);
            name = textbox_name.Text;
        }
    }
}
