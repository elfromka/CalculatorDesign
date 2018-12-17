using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CalculatorDesign
{
    public partial class Form1 : Form
    {
        /*
         * Make the windowsform draggable
         * ------------------------------------------
         */

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        /*
         * ------------------------------------------
         */

        public Form1()
        {
            InitializeComponent();
            // Adding transparency to label on the blue
            label22.Parent = label21.Parent = label23.Parent = label24.Parent = pictureBox1;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /* 
         * Form1 and pictureBox1 is the full app
         * so separately had to add the dragging for each
         * -------------------------------------------------------------------------------
         */

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                // Gets the e.X and e.Y - the position
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                // Gets the e.X and e.Y - the position
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        /*
        * --------------------------------------------------------------------------------
        */

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label23.ForeColor = Color.White;
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.ForeColor = Color.Lavender;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label24.ForeColor = Color.White;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.ForeColor = Color.Lavender;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = Color.DodgerBlue;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Lavender;
        }

        // #0
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SkyBlue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Lavender;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DodgerBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Lavender;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.DodgerBlue;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Lavender;
        }

        // #9
        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.SkyBlue;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Lavender;
        }

        // #8
        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.SkyBlue;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Lavender;
        }

        // #7
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SkyBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Lavender;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.DodgerBlue;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Lavender;
        }

        // #6
        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.SkyBlue;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Lavender;
        }

        // #5
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.SkyBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Lavender;
        }

        // #4
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.SkyBlue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Lavender;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.DodgerBlue;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Lavender;
        }

        // #3
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SkyBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Lavender;
        }

        // #2
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SkyBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Lavender;
        }

        // #1
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.SkyBlue;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Lavender;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.DodgerBlue;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Lavender;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.DodgerBlue;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Lavender;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.DodgerBlue;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Lavender;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.DodgerBlue;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Lavender;
        }
    }
}
