////Калькулятор

using System;

namespace HomeWork_CSharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Калькулятор!");
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Доступные операции:");
            Console.WriteLine("s - Сумма Первого и Второго числа");
            Console.WriteLine("v - Первое минус Второе число");
            Console.WriteLine("f - Умножение "); 
            Console.WriteLine("d - Деление Первого на Второе число");
            Console.WriteLine("Введите идентификатор операции :");
            String O = Console.ReadLine();
            switch (O)
            {
                case "s":
                    int s = a + b;
                    Console.WriteLine($"{a} + {b} =" + s);
                    break;
                case "v":
                    int v = a + b;
                    Console.WriteLine($"{a} - {b} =" + v);
                    break;
                case "f":
                    int f = a + b;
                    Console.WriteLine($"{a} + {b} =" + f);
                    break;
                case "d":
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        int d = a / b;
                        Console.WriteLine($"{a} - {b} =" + d);
                        break;
                    }
                    break;
            }
            
        }
    }
}
