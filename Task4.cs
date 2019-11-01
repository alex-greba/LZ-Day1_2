using System;
using System.Collections.Generic;
using System.Text;

namespace LZ_Day1_2
{
    public class Task4 : Task
    {
        public class DataIn
        {
            private int a;
            private int b;
            private int c;
            public int A
            {
                get
                {
                    return a;
                }
                //set
                //{
                //    a = Enter();
                //}
            }
            public int B
            {
                get
                {
                    return b;
                }
                //set
                //{
                //    b = Enter();
                //}
            }
            public int C
            {
                get
                {
                    return c;
                }
                //set
                //{
                //    c = Enter();
                //}
            }
            public DataIn()
            {
                Console.Write("A = ");
                a = Enter();
                Console.Write("B = ");
                b = Enter();
                Console.Write("C = ");
                c = Enter();
            }
            public int Enter()
            {
                if (int.TryParse(Console.ReadLine(), out int correctly) && correctly > 0)
                    return correctly;
                else return rnd();
            }
            public int rnd()
            {
                Random random = new Random();
                Console.Write("    Некорректное значение. " +
                        "По умолчанию (new Random()) = ");
                int temp = random.Next(2, 10);
                Console.WriteLine(temp);
                return temp;
            }
        }
        public class Calculation
        {
            public string Calculate(DataIn dataIn)
            {
                int x = dataIn.A / dataIn.C;
                int y = dataIn.B / dataIn.C;
                int n = x * y;
                if (n > 0)
                {
                    double s = dataIn.A * dataIn.B - n * Math.Pow(dataIn.C, 2);
                    return "Прямоугольник " + dataIn.A + " х " + dataIn.B +
                        " размещает " + n + " квадрат(-а,-ов) со стороной " + dataIn.C +
                        "\nПлощадь ненезанятой части прямоугольника составляет: " + s + " кв.ед.";
                }
                else
                    return "На прямоугольнике " + dataIn.A + " х " + dataIn.B +
                        " нельзя разместить ни одного квадрата со стороной " + dataIn.C;
            }
        }
        public override void Go()
        {
        Start: Console.Clear();
            Console.WriteLine("Task4");
            Calculation calculation = new Calculation();
            Console.WriteLine("Введите размеры сторон Исходного Прямоугольника " +
                "A, B " +
                "и размер стороны вписываемого Квадрата С\n" +
                "(целые положительные числа)");
            DataIn dataIn = new DataIn();
            Console.WriteLine("\n" + calculation.Calculate(dataIn));
            Console.WriteLine("\nДля выхода - ESK - ");
            if (Console.ReadKey().Key != ConsoleKey.Escape)
                goto Start;
        }
    }
}
