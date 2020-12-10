using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam.Figure_n_Points
{
    class Figure
    {
        Point A;
        Point B;
        Point C;
        Point D;
        Point E;

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }
        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c, d, null) { }
        public Figure(Point a, Point b, Point c) : this(a, b, c, null, null) { }

        private double LengthSide(Point A, Point B) => Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        public void PerimeterCalculator()
        {
            double Result = 0;
            if (D == null && E == null)
            {
                Result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A);
                Console.WriteLine($"Perimeter {A.Coordinates + B.Coordinates + C.Coordinates} : {Result}");
            }
            else if (E == null)
            {
                Result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A);
                Console.WriteLine($"Perimeter {A.Coordinates + B.Coordinates + C.Coordinates + D.Coordinates}: {Result}");
            }
            else
            {
                Result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
                Console.WriteLine($"Perimeter {A.Coordinates + B.Coordinates + C.Coordinates + D.Coordinates + E.Coordinates}: {Result}");
            }
        }
    }
}
