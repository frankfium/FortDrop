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

namespace fortdrop
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);

            Button b = button1;
            b.Click += new EventHandler(ShowMessage);
            Controls.Add(b);
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(134, 22, 87), Color.FromArgb(255, 166, 158), 326f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ShowMessage(object sender, EventArgs e)
        {
            String[] places;
            places = new string[] { "The Shark", "The Yacht", "The Agency","The Grotto","The Rig","Salty Springs","Sweaty Sands","Pleasent Park","Holly Hedges",
                "Weeping Woods","Slurpy Swamp","Misty Meadows","Lazy Lake", "Retail Row", "Dirty Docks", "Frenzy Farm", "Steamy Stacks","Craggy Cliffs"};
            Random rand = new Random();

            int index = rand.Next(places.Length);
            label4.Text = places[index];
            if (index == 0) {

                pictureBox1.Image = fortdrop.Properties.Resources.shark;

            } else if (index == 1) {
                pictureBox1.Image = fortdrop.Properties.Resources.yacht;
            }
            else if (index == 2)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.agency;
            }
            else if (index == 3)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.grotto;
            }
            else if (index == 4)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.rig;
            }
            else if (index == 5)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.salty;
            }
            else if (index == 6)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.sands;
            }
            else if (index == 7)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.pleasent;
            }
            else if (index == 8)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.holly;
            }
            else if (index == 9)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.Weeping;
            }
            else if (index == 10)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.slurp;
            }
            else if (index == 11)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.misty;
            }
            else if (index == 12)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.lazy;
            }
            else if (index == 13)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.retail;
            }
            else if (index == 14)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.dirty;
            }
            else if (index == 15)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.frenzy;
            }
            else if (index == 16)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.steamy;
            }
            else if (index == 17)
            {
                pictureBox1.Image = fortdrop.Properties.Resources.craggy;
            }
            else
            {
                pictureBox1.Image = null;
            }

            label4.Refresh();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
