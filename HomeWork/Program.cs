using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            TASK10();
        }
        static void HomeWork()
        {
            string F = Console.ReadLine();
            Console.WriteLine("Hello, " + F);
        }
        static void TASK2()
        {
            string number1 = Console.ReadLine();
            int no1 = int.Parse(number1);
            string number2 = Console.ReadLine();
            int no2 = int.Parse(number1);
            int sum = no1 + no2;
            Console.WriteLine($"{no1}+{no2}={sum}");
        }
        static void TASK3()
        {
            int no1 = -1 + 4 * 6;
            int no2 = (35 + 5) % 7;
            double no3 = 14 + (-4 * 6) / 11.0;
            double no4 = 2 + 15 / 6.0 * 1 - 7 % 2;
            Console.WriteLine("{0} {1} {2} {3}", no1, no2, no3, no4);

        }
        static void TASK4()
        {
            int no1 = int.Parse(Console.ReadLine());
            int no2 = int.Parse(Console.ReadLine());
            int no3 = int.Parse(Console.ReadLine());
            int no4 = no1 * no2 * no3;
            Console.WriteLine($"{no1} * {no2} * {no3} = {no4}");
        }
        static void TASK5()
        {
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{no1} * 1 = {no1 * 1} \n{no1} * 2 = {no1 * 2} \n{no1} * 3 = {no1 * 3} \n{no1} * 4 = {no1 * 4} \n{no1} * 5 = {no1 * 5} \n{no1} * 6 = {no1 * 6} \n{no1} * 7 = {no1 * 7} \n{no1} * 8 = {no1 * 8} \n{no1} * 9 = {no1 * 9} \n{no1} * 10 = {no1 * 10} \n");
        }
        static void TASK6()
        {
            int no1 = int.Parse(Console.ReadLine());
            int no2 = int.Parse(Console.ReadLine());
            int no3 = int.Parse(Console.ReadLine());
            int no4 = int.Parse(Console.ReadLine());
            double a = (no1 + no2 + no3 + no4) / 4.0;
            Console.WriteLine(a);
        }
        static void TASK7()
        {
            int no1 = int.Parse(Console.ReadLine());
            if (no1 >= 100 && no1 <= 200)
            {
                Console.WriteLine("Given integer is within range between 100 and 200.");
            }
            else
            {
                Console.WriteLine("Given integer isn't within range between 100 and 200.");
            }

        }
        static void TASK8()
        {
            DateTime no1 = DateTime.Now;
            Console.WriteLine(no1.ToString("dd/MM/yy"));

        }
        static void TASK9()
        {
            Console.WriteLine("Please,tape your age;");
            int a = int.Parse(Console.ReadLine());
            int b = 2020 - a;
            Console.WriteLine($"You were born in {b}");
        }
        static void TASK10()
        {
            Console.WriteLine("Please, tape the X");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the Y");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the Z");
            int Z = int.Parse(Console.ReadLine());
            Console.WriteLine($"(x+y)*z = {(X+Y) * Z }\nx*y+y*z={X*Y+Y*Z}");

        }
    }

}
       
    


