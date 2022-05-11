using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventExample
{
    public partial class SimpleEventExample : Form
    {
        private int imageNumber { get; set; } = 0;
        public SimpleEventExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageNumber %= 3; 

           pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"image{++imageNumber}"));
        }
    }
}
