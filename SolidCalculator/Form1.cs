using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double cubLen = double.Parse(textBox1.Text);
            double cubWid = double.Parse(textBox2.Text);
            double cubH = double.Parse(textBox3.Text);
            MessageBox.Show(Convert.ToString(Program.Cuboid(cubLen, cubWid, cubH)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double cylRad = double.Parse(textBox4.Text);
            double cylH = double.Parse(textBox5.Text);
            MessageBox.Show(Convert.ToString(Program.Cylinder(cylRad, cylH)));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            double conRad = double.Parse(textBox7.Text);
            double conH = double.Parse(textBox6.Text);
            MessageBox.Show(Convert.ToString(Program.Cone(conRad, conH)));
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            double sphRad = double.Parse(textBox8.Text);
            MessageBox.Show(Convert.ToString(Program.Sphere(sphRad)));
        }
    }
}