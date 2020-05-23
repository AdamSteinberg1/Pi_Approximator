using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PI_Approximator2
{
    class Point
    {
        static private Size formSize;
        static Pixel center = new Pixel(0,0); //the center of the coordinate plane in pixels
        static int pixels_per_unit = 100; //how many pixels 1 unit is long
        
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point()
        {
            X = 0.0;
            Y = 0.0;
        }

        public Pixel toPixel()
        {
            
            return new Pixel((int)(pixels_per_unit * X + center.X), (int)(-pixels_per_unit * Y + center.Y));
        }

        static public void setFormSize(Size _formSize)
        {
            formSize = _formSize;
            center.X = formSize.Width / 2;
            center.Y = formSize.Height / 2;
            pixels_per_unit = (int)(Math.Min(formSize.Width, formSize.Height)*0.25);
        }
    }
}
