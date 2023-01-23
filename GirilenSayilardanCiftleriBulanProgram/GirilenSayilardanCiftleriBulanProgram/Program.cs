using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayilardanCiftleriBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler ile kullanıcının girdiği sayıdan 0'a kadar olan cift sayilari ekrana yazdiriyoruz.

            int sayi;

            Console.Write("Bir sayi giriniz:");
            sayi = int.Parse(Console.ReadLine());

            for (int i = sayi; i >= 0; i--)
            {
                if (i %2 ==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}








