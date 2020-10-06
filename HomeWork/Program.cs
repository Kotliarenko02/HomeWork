using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            TASK2();
        }
        static void HomeWork()
        {
            string F = Console.ReadLine();
            Console.WriteLine("Hello, " + F);
        }
        static void TASK2()
        {
         string number1= Console.ReadLine();
            int no1 = int.Parse(number1);
            string number2 = Console.ReadLine();
            int no2 = int.Parse(number1);
            int sum = no1 + no2;
            Console.WriteLine($"{no1}+{no2}={sum}");
        }
    }
}
