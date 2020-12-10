using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Figure_n_Points
{
    class Point
    {
        public Point(double X, double Y, string Coordinates)
        {
            this.X = X;
            this.Y = Y;
            this.Coordinates = Coordinates;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public string Coordinates { get; set; }
    }
}
