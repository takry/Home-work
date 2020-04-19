//Рандомный массив из 10 чисел и сумма четных чисел в нем


using System;

namespace Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] a = new int[10];
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next();
            }
            for ( int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Сумма четных числе=");
            for (int i = 0; i < a.Length; i++)
            {
            if (a[i]%2==0)
                {
                    int b = a[i];
                    Console.WriteLine(b);
                    Console.WriteLine('+');
                    c = c + b; 
                }
            }
            Console.WriteLine('=');
            Console.WriteLine(c);
        }   


    }
}
