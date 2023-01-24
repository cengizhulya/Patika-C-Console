using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkininKuvvetleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler ile 1'den girilen sayıya kadar olan 2'nin kuvvetlerini ekrana yazdıran programı yazıyoruz.

            int enSonKuvvet;
            int taban = 2;
            
            Console.Write("2'nin kaca kadar olan kuvvetlerini yazdiracaksiniz:");
            enSonKuvvet = int.Parse(Console.ReadLine());

            int sonuc = 1;

            for (int j=1; j<=enSonKuvvet; j++)
            {
                sonuc = sonuc*taban;

                Console.WriteLine("2'nin {0}.kuvveti=" + sonuc, j);
            }

            Console.ReadLine();
        }
    }
}