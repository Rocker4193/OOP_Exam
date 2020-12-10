using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Area
        { 
            get
            {
                return AreaCalculator();
            } 
            set { } 
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
            set { }
        }
    }
}
