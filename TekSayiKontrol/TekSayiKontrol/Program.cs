using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekSayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler ile tek bir sayı girilene kadar kullanıcıdan girişleri kabul eden ve girilen değerlerden çift ve 4'ün katları olan sayıları toplayıp ekrana basan programı yazıyoruz.

            int sayi;            
            int toplam = 0;

            Console.Write("Bir sayi girin:");
            sayi = int.Parse(Console.ReadLine());

            while (sayi % 2 == 0)
            {
                if (sayi%2==0 && sayi % 4 == 0)
                {
                    toplam = toplam + sayi;
                }

                Console.Write("Bir sayi girin:");
                sayi = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Tek sayi girdiniz");

            Console.ReadLine();

        }
    }
}









