using System;
using System.Collections.Generic;
using System.Text;

namespace LZ_Day1_2
{
    public class Task5 : Task
    {
        public class Request
        {
            private readonly decimal deposit = 1000;
            public decimal Deposit
            {
                get { return deposit; }
            }
            private double P;
            public double p
            {
                set
                {
                    if (value > 0)
                        P = value;
                    else
                        defaultValue();

                }
            }
            private decimal Goal;
            public decimal goal
            {
                set
                {
                    if (value > deposit)
                        Goal = value;
                    else
                        defaultValue();
                }
            }
            public void defaultValue()
            {
                Console.WriteLine("Значение некорректно или не имеет смысла. " +
                            "Будет принято значение по умолчанию");
            }
            private int K = 0;
            private decimal S;
            public Request(int p = 5, decimal goal = 1050)
            {
                P = p;
                Goal = goal;
                S = deposit;
            }
            public string Calculate()
            {
                while (S <= Goal)
                {
                    K++;
                    S += S * (decimal)P * 0.01m;
                }
                return "\nПРИНЯТО" +
                    "\n                       Процент P = " + P +
                    "\n     Достижение вкладом размера в: " + Goal +
                    "\n\nВЫЧЕСЛЕНО" +
                    "\nНеобходимое количество месяцев K = " + K +
                    "\n        Итоговый размер вклада S = " + S;
            }
        }
        public override void Go()
        {
        Start: Console.Clear();
            Console.WriteLine("Task5");
            Request request = new Request();
            Console.WriteLine("Текущий вклад состовляет: " + request.Deposit);
            Console.Write("Процент: ");
            if (double.TryParse(Console.ReadLine(), out double p))
                request.p = p;
            else
                request.defaultValue();
            Console.Write("Достижение вкладом размера в: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal goal))
                request.goal = goal;
            else
                request.defaultValue();
            Console.WriteLine(request.Calculate());
            Console.WriteLine("\nДля выхода - ESK - ");
            if (Console.ReadKey().Key != ConsoleKey.Escape)
                goto Start;
        }
    }
}
