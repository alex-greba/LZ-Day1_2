using System;
using System.Collections.Generic;
using System.Text;

namespace LZ_Day1_2
{
    public class Task2 : Task
    {

        public class Triangle
        {
            double A { get; set; }
            double B { get; set; }
            double C { get; set; }
            private double P { get; set; }
            public double getP()
            {
                return P;
            }
            double S { get; set; }
            public int X1, X2, X3, Y1, Y2, Y3;
            public Triangle(int x1 = 0, int y1 = 0, int x2 = 0, int y2 = 5, int x3 = 5, int y3 = 0)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                X3 = x3;
                Y3 = y3;
            }
            public double Perimetr()
            {
                A = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
                B = Math.Sqrt(Math.Pow(X2 - X3, 2) + Math.Pow(Y2 - Y3, 2));
                C = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
                Console.WriteLine();
                P = A + B + C;
                return P;
            }
            public double Square()
            {
                double p;
                if (P != 0)
                    p = P / 2;
                else
                    p = Perimetr() / 2;
                S = Math.Pow(p * (p - A) * (p - B) * (p - C), 1 / 2f);
                return S;
            }
        }
        public override void Go()
        {
            Console.Clear();
            Console.WriteLine("Task2");
            Triangle T = new Triangle(0, 0, 0, 5, 5, 0);
            Console.WriteLine("Дано:\n" +
                "Triangle T = new Triangle(0, 0, 0, 5, 5, 0);\n" +
                " - ANY KEY -");
            Console.ReadKey();
            Console.WriteLine(
                "\n          Периметр = " + T.Perimetr() +
                "\n           Площадь = " + T.Square() +
                "\nПериметр(округлён) = {0:0.000}", T.getP());
            Console.ReadKey();
        }
    }
}
