using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongSayilariBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Armstrong Sayı Nedir ?
           n haneli bir sayının basamaklarının n’inci üstlerinin toplamı, sayının kendisine eşitse, böyle sayılara Armstrong sayı denir.
           Örneğin 407 sayısını ele alalım. (4^3)+ (0^3)+(7^3) = 64+0+343 = 407 sonucunu verir. Bu da 407 sayısının armstrong bir sayı olduğunu gösterir.*/

            int toplam = 0;

            Console.Write("Armstrong sayiyisi olup olmadigi kontrol edilecek sayiyi girin:");

            string sayi;
            sayi = Console.ReadLine();

           for(int i = 0; i < sayi.Length; i++)
            {

               int sonuc = 1;

                for (int j = 0; j < sayi.Length; j++)
                {

                    sonuc = sonuc * Convert.ToInt32(sayi[i].ToString());
         
                }

                toplam = toplam + sonuc;
            }

            if(toplam == Convert.ToInt32(sayi))
            {
                Console.WriteLine("Girilen sayi armstrong sayidir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi armstrong sayi degildir.");
            }

            Console.ReadLine();
        }
    }
}