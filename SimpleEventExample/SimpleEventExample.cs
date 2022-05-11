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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("example make by ME ! ","About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFonts()
        {
           timesNewRomanToolStripMenuItem.Checked = false;
            comicSanseToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
        }


        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFonts();
            timesNewRomanToolStripMenuItem.Checked = true;
            label1.Font = new Font("Times New Roman", 20, label1.Font.Style);
        }

        private void comicSanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFonts();
            comicSanseToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans", 20, label1.Font.Style);
        }
                                   
        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFonts();
            courierToolStripMenuItem.Checked = true;
            label1.Font = new Font("Courier", 20, label1.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
             label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}
