using System;

namespace LZ_Day1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] Tasks = new Task[5];
            Tasks[0] = new Task1();
            Tasks[1] = new Task2();
            Tasks[2] = new Task3();
            Tasks[3] = new Task4();
            Tasks[4] = new Task5();
            foreach (Task Task in Tasks)
            {
                Task.Go();
            }
        }
    }
}
