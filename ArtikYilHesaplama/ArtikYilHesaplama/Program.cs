using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikYilHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***Artik Yil Hesaplama*** \n");

            int yil;
            double kalan;

            Console.Write("Yıl giriniz:");
            yil = int.Parse(Console.ReadLine());

            if (yil % 4 == 0)
            {
                Console.WriteLine("{0}",yil+" artik yildir");
            }
            else if (yil % 400 == 0)
            {
                Console.WriteLine("{0}", yil + " artik yildir");
            }
            else
            {
                Console.WriteLine("{0}", yil + " artik yil degildir");
            }

            Console.ReadLine();

        }
    }
}