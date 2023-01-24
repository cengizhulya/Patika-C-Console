using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayiyaKadar4ve5inKuvvetleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban1 = 4;
            int taban2 = 5;
            int sayi;
            int sonuc1 = 1;
            int sonuc2 = 1;

            Console.Write("Hangi sayiya kadar 4 ve 5'in kuvvetleri yazilsin:");
            sayi = int.Parse(Console.ReadLine());

            for(int i = 0; i <=100; i++)
            {
                sonuc1 = sonuc1 * taban1;
                
                if (sonuc1 > sayi)
                {
                    break;
                }

                Console.WriteLine(sonuc1);

            }

            for (int i = 0; i <= 100; i++)
            {
                sonuc2 = sonuc2 * taban2;
              
                if (sonuc2 > sayi)
                {
                    break;
                }

                Console.WriteLine(sonuc2);

            }

            Console.ReadLine();
        }
    }
}