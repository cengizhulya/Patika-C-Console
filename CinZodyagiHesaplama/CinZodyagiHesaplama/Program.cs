using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinZodyagiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***Cin Zodyagi Hesaplama*** \n");

            int dogumyili;
            double kalan;

            Console.Write("Dogum yilinizi girin:");
            dogumyili = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            kalan = dogumyili % 12;

            if (kalan == 0)
            {
                Console.WriteLine("Maymun");
            }
            else if (kalan == 1)
            {
                Console.WriteLine("Horoz");
            }
            else if (kalan == 2)
            {
                Console.WriteLine("Kopek");
            }
            else if (kalan == 3)
            {
                Console.WriteLine("Domuz");
            }
            else if (kalan == 4)
            {
                Console.WriteLine("Fare");
            }
            else if (kalan == 5)
            {
                Console.WriteLine("Öküz");
            }
            else if (kalan == 6)
            {
                Console.WriteLine("Kaplan");
            }
            else if (kalan == 7)
            {
                Console.WriteLine("Tavsan");
            }
            else if (kalan == 8)
            {
                Console.WriteLine("Ejderha");
            }
            else if (kalan == 9)
            {
                Console.WriteLine("Yilan");
            }
            else if (kalan == 10)
            {
                Console.WriteLine("At");
            }
            else if (kalan == 11)
            {
                Console.WriteLine("Koyun");
            }

            Console.ReadLine();
        }
    }
}