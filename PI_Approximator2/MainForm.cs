using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Approximator2
{
    public partial class MainForm : Form
    {
        int numSides = 3;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Point.setFormSize(this.Size);
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            drawCircle(g);
            drawN_gon(g);
        }

        private void drawCircle(Graphics g)
        {
            Pen pn = new Pen(Color.Blue, 6);

            //top left and bottom right corners that define our rectangle
            Point topLeft = new Point(-1, 1);
            Point botRight = new Point(1, -1);

            int width = botRight.toPixel().X - topLeft.toPixel().X;
            int height = botRight.toPixel().Y - topLeft.toPixel().Y;
            Rectangle rect = new Rectangle(topLeft.toPixel().X, topLeft.toPixel().Y, width, height);

            g.DrawEllipse(pn, rect); //an ellipse inscribed in our rectangle
        }
        private void drawN_gon(Graphics g)
        {            
            List<Complex> inner_points = nth_roots_of_unity(numSides);
            inner_points.Sort((x, y) => x.Phase.CompareTo(y.Phase)); //sorts complex points by phase

            //construct outer n-gon
            List<Complex> outer_points = new List<Complex>(inner_points.Count);
            for (int i = 0; i < outer_points.Capacity - 1; i++)
            {
                outer_points.Add(findIntersectionOfTangentLines(inner_points[i], inner_points[i + 1]));
            }
            outer_points.Add(findIntersectionOfTangentLines(inner_points.First(), inner_points.Last()));

            //draw inner n-gon
            Pen pn = new Pen(Color.Red, 2);
            for (int i = 0; i < inner_points.Count - 1; i++)
            {
                drawLineBetweenComplexNums(inner_points[i], inner_points[i+1], g, pn);
            }
            drawLineBetweenComplexNums(inner_points.First(), inner_points.Last(), g, pn);            

            //draw outer n-gon
            pn.Color = Color.Green;
            for (int i = 0; i < outer_points.Count - 1; i++)
            {
                drawLineBetweenComplexNums(outer_points[i], outer_points[i + 1], g, pn);
            }
            drawLineBetweenComplexNums(outer_points.First(), outer_points.Last(), g, pn);
            
            double inner_perimeter = inner_points.Count * distance(inner_points[0], inner_points[1]);
            double outer_perimeter = outer_points.Count * distance(outer_points[0], outer_points[1]);
            double pi_approx = (inner_perimeter + outer_perimeter) / 4; //average of half of inner and half of outer

            InnerLabel.Text = "Inscribed Perimeter: " + inner_perimeter;
            OuterLabel.Text = "Circumscribed Perimeter " + outer_perimeter;
            Approx.Text = "Current π Approximation: " + pi_approx;

        }

        private void drawLineBetweenComplexNums(Complex n1, Complex n2, Graphics g, Pen pn)
        {
            Point p1 = new Point(n1.Real, n1.Imaginary);
            Point p2 = new Point(n2.Real, n2.Imaginary);
            g.DrawLine(pn, p1.toPixel().X, p1.toPixel().Y, p2.toPixel().X, p2.toPixel().Y);
        }

        private double distance(Complex p1, Complex p2)
        {
            return Math.Sqrt((p1.Real - p2.Real) * (p1.Real - p2.Real) + (p1.Imaginary - p2.Imaginary) * (p1.Imaginary - p2.Imaginary));
        }

        private Complex findIntersectionOfTangentLines(Complex c1, Complex c2)
        {
            double x, y;
            //edge cases to avoid dividing by 0
            if (c1.Imaginary == 0)
            {
                if (c1.Real > 0) // c1 = (1,0)
                {
                     y = (-c2.Real / c2.Imaginary) * (1 - c2.Real) + c2.Imaginary;
                     x = 1;
                }
                else // c1 = (-1, 0)
                {
                     y = (-c2.Real / c2.Imaginary) * (-1 - c2.Real) + c2.Imaginary;
                     x = -1;
                }
            }
            else if (c2.Imaginary == 0)
            {
                if (c2.Real > 0) // c2 = (1,0)
                {
                     y = (-c1.Real / c1.Imaginary) * (1 - c1.Real) + c1.Imaginary;
                     x = 1;
                }
                else // c2 = (-1, 0)
                {
                     y = (-c1.Real / c1.Imaginary) * (-1 - c1.Real) + c1.Imaginary;
                     x = -1;
                }
            }
            //general case
            else
            {
                 x = (-c1.Real * c1.Real * c2.Imaginary - c1.Imaginary * c1.Imaginary * c2.Imaginary + c2.Real * c2.Real * c1.Imaginary + c1.Imaginary * c2.Imaginary * c2.Imaginary) / (c2.Real * c1.Imaginary - c1.Real * c2.Imaginary);
                 y = -(c1.Real / c1.Imaginary) * (x - c1.Real) + c1.Imaginary;
            }
            return new Complex(x, y);
        }

        private List<Complex> nth_roots_of_unity(int n)
        {
            //create polynomial of the form x^n -1 
            double[] coefficients = new double[n + 1];
            coefficients[0] = -1;
            coefficients[n] = 1;
            return FindRoots.Polynomial(coefficients).ToList();
        }

        private void redraw()
        {
            int numRead;
            bool parsed = Int32.TryParse(numSidesBox.Text, out numRead);
            if (parsed && numRead >= 3)
            {
                numSides = numRead;
                Refresh();
                
            }
            else
            {
                numSidesBox.Text = numSides.ToString();
                numSidesBox.SelectionStart = numSidesBox.Text.Length;
            }
        }

        private void Increment_Click(object sender, EventArgs e)
        {
            numSides++;
            numSidesBox.Text = numSides.ToString();            
            redraw();
        }

        private void Decrement_Click(object sender, EventArgs e)
        {
            if (numSides > 3)
            {
                numSides--;
                numSidesBox.Text = numSides.ToString();
                redraw();
            }
        }

        private void numSidesBox_Leave(object sender, EventArgs e)
        {
            redraw();
        }

        private void numSidesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                redraw();
                e.Handled = true;
            }
        }
        private void MainForm_ClientSizeChanged(object sender, EventArgs e)
        {
            Point.setFormSize(this.ClientSize);
            Refresh();

            int scale = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 1000;
            //TODO make text change size
        }
    }
}
