using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekSayilarinToplaminiBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler ile negatif bir değer girilene kadar kullanıcıdan girişleri kabul eden ve girilen değerlerden tek sayıları toplayıp ekrana basan programı yazıyoruz.

            int sayi;
            int toplam=0;

            Console.Write("Bir sayi girin:");
            sayi = int.Parse(Console.ReadLine());

            while (sayi >= 0)
            {

                if (sayi % 2 != 0)
                {
                    toplam = toplam + sayi;
                }

                Console.Write("Bir sayi girin:");
                sayi = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Toplam:"+toplam);

            Console.ReadLine();
        }
    }
}