using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;


namespace _11_TurtleGraphics_Hexa_GUI
    {
    public partial class FormTurtleGraphics : System.Windows.Forms.Form
        {
        public FormTurtleGraphics()
            {
            InitializeComponent();
            }

        private void buttonDraw_Click(object sender, EventArgs e)
            {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
            }

        private void buttonReset_Click(object sender, EventArgs e)
            {
            Turtle.Reset();
            }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
            {
            if (Turtle.ShowTurtle)
                {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
                }
            else
                {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
                }
            }

        private void buttonHexagon_Click(object sender, EventArgs e)
            {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw Hexagon
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            }
        }
    }
