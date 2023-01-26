using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSerisi
{
    class Program
    {
        static void Main(string[] args)
        {                               

            int kacEleman;

            Console.Write("Fibonacci serisi kac elemanli olacak:");
            kacEleman = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = a+b;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            for (int i = 1; i <= (kacEleman-3) ; i++)
            {
                a = b;
                b = c;
                c = a+b;

                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}