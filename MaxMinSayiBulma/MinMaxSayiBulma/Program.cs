using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;

            int enBuyuk;
            int enKucuk;

            int eleman;

            Console.Write("Kac tane sayi gireceksiniz:");
            i = int.Parse(Console.ReadLine());

            int[] sayilar = new int [i] ;

            for(int k = 0; k < i ; k++)
            {
                Console.Write(k+1+"."+"elemani girin:");
                eleman = int.Parse(Console.ReadLine());

                sayilar[k] = eleman;
            }

            enBuyuk = sayilar[0];

            for (int j = 0; j < i; j++)
            {

                if (enBuyuk < sayilar[j])
                {
                    enBuyuk = sayilar[j];       
                }

            }

            Console.WriteLine("En buyuk eleman:"+enBuyuk);

            enKucuk = sayilar[0];

            for (int k= 0; k < i ; k++)
            {
                if (enKucuk > sayilar[k])
                {
                    enKucuk = sayilar[k];
                }

            }

            Console.WriteLine("En kucuk:"+enKucuk);

            Console.ReadLine();
        }
    }
}