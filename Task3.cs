using System;
using System.Collections.Generic;
using System.Text;

namespace LZ_Day1_2
{
    public class Task3 : Task
    {
        public class Number
        {
            private int N { get; set; }
            char[] x;

            public Number()
            {
                Random rnd = new Random();
                N = rnd.Next(100, 999);
            }
            public int getN()
            {
                return N;
            }
            public void setN(int n)
            {
                N = n;
            }
            public override string ToString()
            {
                x = N.ToString().ToCharArray();
                string Total = null;
                switch (x[0])
                {
                    case '1': Total += "сто"; break;
                    case '2': Total += "двести"; break;
                    case '3': Total += "триста"; break;
                    case '4': Total += "четыреста"; break;
                    case '5': Total += "пятьсот"; break;
                    case '6': Total += "шестьсот"; break;
                    case '7': Total += "семьсот"; break;
                    case '8': Total += "восемьсот"; break;
                    case '9': Total += "девятьсот"; break;
                }
                switch (x[1])
                {
                    case '0': Total += ""; break;
                    case '1': Total += ""; break;
                    case '2': Total += " двадцать"; break;
                    case '3': Total += " тридцать"; break;
                    case '4': Total += " сорок"; break;
                    case '5': Total += " пятьдесят"; break;
                    case '6': Total += " шестьдесят"; break;
                    case '7': Total += " семьдесят"; break;
                    case '8': Total += " восемьдесят"; break;
                    case '9': Total += " девяносто"; break;
                }
                if (x[1] != '1')
                {
                    switch (x[2])
                    {
                        case '0': Total += ""; break;
                        case '1': Total += " один"; break;
                        case '2': Total += " два"; break;
                        case '3': Total += " три"; break;
                        case '4': Total += " четыре"; break;
                        case '5': Total += " пять"; break;
                        case '6': Total += " шестьт"; break;
                        case '7': Total += " семь"; break;
                        case '8': Total += " восемь"; break;
                        case '9': Total += " девять"; break;
                    }
                }
                else
                {
                    switch (x[2])
                    {
                        case '0': Total += " десять"; break;
                        case '1': Total += " одиннадцать"; break;
                        case '2': Total += " двенадцать"; break;
                        case '3': Total += " тринадцать"; break;
                        case '4': Total += " четырнадцать"; break;
                        case '5': Total += " пятнадцать"; break;
                        case '6': Total += " шестнадцать"; break;
                        case '7': Total += " семнадцать"; break;
                        case '8': Total += " восемнадцать"; break;
                        case '9': Total += " девятнадцать"; break;
                    }
                }
                return Total;
            }
        }
        public override void Go()
        {
            Console.Clear();
            Console.WriteLine("Task3");
        Start: Number number = new Number();
            Console.WriteLine("Введите целое число N в диапазоне 100 - 999:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 99 && n < 1000)
            {
                number.setN(n);
                Console.WriteLine("N = {0}", n);
            }
            else
            {
                Console.WriteLine("Некорректное число\n" +
                    "По умолчанию (new Random()) N = " + number.getN());
            }
            Console.WriteLine("output: " + number.ToString());
            Console.WriteLine("\nДля выхода - ESK - ");
            if (Console.ReadKey().Key != ConsoleKey.Escape)
                goto Start;
        }
    }
}
