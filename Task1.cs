using System;
using System.Collections.Generic;
using System.Text;

namespace LZ_Day1_2
{
    public class Task1 : Task
    {
        public override void Go()
        {
            Console.Clear();
            Console.WriteLine("Task1");
            Console.WriteLine("Введите значение температуры в градусах Фаренгейта:  ");
            string f = Console.ReadLine();
            if (int.TryParse(f, out int Tf))
            {
                int Tc = (Tf - 32) * 5 / 9;
                Console.WriteLine(Tf + "F = " + Tc + "C");
            }
            Console.ReadKey();
        }
    }
}
