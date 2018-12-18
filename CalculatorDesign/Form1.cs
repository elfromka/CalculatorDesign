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

        /* 
         *  ------------------------- DESIGN ---------------------------------------------
         */

        // Close button
        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label23.ForeColor = Color.White;
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.ForeColor = Color.Lavender;
        }

        // Minimize button
        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label24.ForeColor = Color.White;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.ForeColor = Color.Lavender;
        }

        private void clearButton_MouseEnter(object sender, EventArgs e)
        {
            clearButton.ForeColor = Color.DodgerBlue;
        }

        private void clearButton_MouseLeave(object sender, EventArgs e)
        {
            clearButton.ForeColor = Color.Lavender;
        }

        private void divisionButton_MouseEnter(object sender, EventArgs e)
        {
            divisionButton.ForeColor = Color.DodgerBlue;
        }

        private void divisionButton_MouseLeave(object sender, EventArgs e)
        {
            divisionButton.ForeColor = Color.Lavender;
        }

        private void modulusButton_MouseEnter(object sender, EventArgs e)
        {
            modulusButton.ForeColor = Color.DodgerBlue;
        }

        private void modulusButton_MouseLeave(object sender, EventArgs e)
        {
            modulusButton.ForeColor = Color.Lavender;
        }

        private void multiplyButton_MouseEnter(object sender, EventArgs e)
        {
            multiplyButton.ForeColor = Color.DodgerBlue;
        }

        private void multiplyButton_MouseLeave(object sender, EventArgs e)
        {
            multiplyButton.ForeColor = Color.Lavender;
        }

        private void substractionButton_MouseEnter(object sender, EventArgs e)
        {
            substractionButton.ForeColor = Color.DodgerBlue;
        }

        private void substractionButton_MouseLeave(object sender, EventArgs e)
        {
            substractionButton.ForeColor = Color.Lavender;
        }

        private void additionButton_MouseEnter(object sender, EventArgs e)
        {
            additionButton.ForeColor = Color.DodgerBlue;
        }

        private void additionButton_MouseLeave(object sender, EventArgs e)
        {
            additionButton.ForeColor = Color.Lavender;
        }

        private void parenthesisButton_MouseEnter(object sender, EventArgs e)
        {
            parenthesisButton.ForeColor = Color.DodgerBlue;
        }

        private void parenthesisButton_MouseLeave(object sender, EventArgs e)
        {
            parenthesisButton.ForeColor = Color.Lavender;
        }

        private void decimalButton_MouseEnter(object sender, EventArgs e)
        {
            decimalButton.ForeColor = Color.DodgerBlue;
        }

        private void decimalButton_MouseLeave(object sender, EventArgs e)
        {
            decimalButton.ForeColor = Color.Lavender;
        }

        private void backspaceButton_MouseEnter(object sender, EventArgs e)
        {
            backspaceButton.ForeColor = Color.DodgerBlue;
        }

        private void backspaceButton_MouseLeave(object sender, EventArgs e)
        {
            backspaceButton.ForeColor = Color.Lavender;
        }

        private void nOneButton_MouseEnter(object sender, EventArgs e)
        {
            nOneButton.ForeColor = Color.SkyBlue;
        }

        private void nOneButton_MouseLeave(object sender, EventArgs e)
        {
            nOneButton.ForeColor = Color.Lavender;
        }

        private void nTwoButton_MouseEnter(object sender, EventArgs e)
        {
            nTwoButton.ForeColor = Color.SkyBlue;
        }

        private void nTwoButton_MouseLeave(object sender, EventArgs e)
        {
            nTwoButton.ForeColor = Color.Lavender;
        }

        private void nThreeButton_MouseEnter(object sender, EventArgs e)
        {
            nThreeButton.ForeColor = Color.SkyBlue;
        }

        private void nThreeButton_MouseLeave(object sender, EventArgs e)
        {
            nThreeButton.ForeColor = Color.Lavender;
        }
       
        private void nFourButton_MouseEnter(object sender, EventArgs e)
        {
            nFourButton.ForeColor = Color.SkyBlue;
        }

        private void nFourButton_MouseLeave(object sender, EventArgs e)
        {
            nFourButton.ForeColor = Color.Lavender;
        }

        private void nFiveButton_MouseEnter(object sender, EventArgs e)
        {
            nFiveButton.ForeColor = Color.SkyBlue;
        }

        private void nFiveButton_MouseLeave(object sender, EventArgs e)
        {
            nFiveButton.ForeColor = Color.Lavender;
        }

        private void nSixButton_MouseEnter(object sender, EventArgs e)
        {
            nSixButton.ForeColor = Color.SkyBlue;
        }

        private void nSixButton_MouseLeave(object sender, EventArgs e)
        {
            nSixButton.ForeColor = Color.Lavender;
        }

        private void nSevenButton_MouseEnter(object sender, EventArgs e)
        {
            nSevenButton.ForeColor = Color.SkyBlue;
        }

        private void nSevenButton_MouseLeave(object sender, EventArgs e)
        {
            nSevenButton.ForeColor = Color.Lavender;
        }

        private void nEightButton_MouseEnter(object sender, EventArgs e)
        {
            nEightButton.ForeColor = Color.SkyBlue;
        }

        private void nEightButton_MouseLeave(object sender, EventArgs e)
        {
            nEightButton.ForeColor = Color.Lavender;
        }

        private void nNineButton_MouseEnter(object sender, EventArgs e)
        {
            nNineButton.ForeColor = Color.SkyBlue;
        }

        private void nNineButton_MouseLeave(object sender, EventArgs e)
        {
            nNineButton.ForeColor = Color.Lavender;
        }

        private void nZeroButton_MouseEnter(object sender, EventArgs e)
        {
            nZeroButton.ForeColor = Color.SkyBlue;
        }

        private void nZeroButton_MouseLeave(object sender, EventArgs e)
        {
            nZeroButton.ForeColor = Color.Lavender;
        }

        /* 
        *  ------------------------- DESIGN ENDS --------------------------------------
        */

        private void number_click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            label22.Text = label22.Text + number.Text;
        }
    }
}
