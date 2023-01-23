using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcveDordeBolunenSayilarinOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler ile 0'dan girilen sayıya kadar olan sayılardan 3 ve 4'e tam bölünen sayıların ortalamasını hesaplayan programı yazınız.

            int sayi;
            int bolunenSayilarinSayisi = 0;
            int toplam = 0;
            double ortalama;

            Console.Write("Bir sayi girin:");
            sayi = int.Parse(Console.ReadLine());   

            for(int i = 1; i <= sayi; i++)
            {
                if(i % 3 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                    bolunenSayilarinSayisi++;
                }
            }

            if (bolunenSayilarinSayisi == 0)
            {
                Console.WriteLine("Girilen sayidan 0'a kadar 3 ve 4'e bolunen sayi yok");
            }
            else
            {
                ortalama = toplam / bolunenSayilarinSayisi;
                Console.WriteLine("Ortalama:" + ortalama);
            }

            Console.ReadLine();
        }
    }
}