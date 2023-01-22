using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminEtmeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***Sayi Tahmin Etme Oyunu*** \n");

            int tahminEdilenSayi;

            int kalanTahminHakki=10;

            Random random = new Random();
            int number = random.Next(0, 100);

            Console.Write("10 tane tahmin etme hakkin var, ");

            for (int i = 10; i >= 1; i--) 
            {

                Console.Write("0 ile 100 arasinda tuttugum sayiyi tahmin et:");
                tahminEdilenSayi = int.Parse(Console.ReadLine());

                if (tahminEdilenSayi == number)
                {
                    Console.WriteLine("Dogru tahmin ettin");
                    break;
                }
                if (tahminEdilenSayi > number)
                {
                    Console.WriteLine("Tahmin ettigin sayi tuttugum sayidan buyuk ");
                    kalanTahminHakki--;
                    Console.WriteLine("Kalan tahmin hakki:"+kalanTahminHakki+"\n");
                }
                if (tahminEdilenSayi < number)
                {
                    Console.WriteLine("Tahmin ettigin sayi tuttugum sayidan kucuk ");
                    kalanTahminHakki--;
                    Console.WriteLine("Kalan tahmin hakki:" +kalanTahminHakki+"\n");
                }
                if (i == 1)
                {
                    Console.WriteLine("Tahmin hakkin doldu, tuttugum sayi "+number);
                }
            }

            Console.ReadLine();

        }
    }
}