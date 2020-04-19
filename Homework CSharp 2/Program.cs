//Задать строку - Вывести четные символы


using System;

namespace Homework_CSharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            string v = Console.ReadLine();
            int g = int.Parse(v);
            int[] a = new int[g];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Введите число");
                Console.WriteLine();
                string c = Console.ReadLine();
                int b = int.Parse(c);
                a[i] = b;
            }
            Console.WriteLine("Четные числа из введенных :");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i]);
                    Console.Write(' ');

                }
            }
        }
    }
}
