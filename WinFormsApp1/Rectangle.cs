using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{

    public class Rectangle
    {
        // Properties
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Calculate Area
        public double CalculateArea()
        {
            return Width * Height;
        }

        // Calculate Perimeter
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

}
