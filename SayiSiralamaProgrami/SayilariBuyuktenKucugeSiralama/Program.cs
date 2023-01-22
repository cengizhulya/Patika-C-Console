using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilariBuyuktenKucugeSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen 3 sayıyı "küçükten büyüğe" sıralayan programı yazınız.

            Console.WriteLine(" ***Girilen 3 Sayiyi Buyukten Kucuge Siralayan Program*** \n");

            int sayi1;
            int sayi2;
            int sayi3;

            Console.Write("1.sayiyi girin:");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayiyi girin:");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("3.sayiyi girin:");
            sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int enBuyukSayi=sayi1;
            int enKucukSayi=sayi2;

            if(sayi1>sayi2 && sayi1 > sayi3)
            {
                enBuyukSayi = sayi1;

                if (sayi2 > sayi3)
                {
                    enKucukSayi = sayi3;

                    Console.WriteLine("{0} > {1} > {2}",sayi1,sayi2,sayi3);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi1, sayi3, sayi2);
                }
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                enBuyukSayi = sayi2;

                if (sayi1 > sayi3)
                {
                    enKucukSayi = sayi3;

                    Console.WriteLine("{0} > {1} > {2}", sayi2, sayi1, sayi3);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi2, sayi3, sayi1);
                }
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                enBuyukSayi = sayi3;

                if (sayi1 > sayi2)
                {
                    enKucukSayi = sayi3;

                    Console.WriteLine("{0} > {1} > {2}", sayi3, sayi1, sayi2);
                }
                else
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi3, sayi2, sayi1);
                }
            }

            Console.ReadLine();
        }
    }
}