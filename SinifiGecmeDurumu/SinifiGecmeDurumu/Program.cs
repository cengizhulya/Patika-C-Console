using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifiGecmeDurumu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dersler : Matematik, Fizik, Türkçe, Kimya, Müzik
             Geçme Notu : 55
             Ödev
             Eğer girilen ders notları 0 veya 100 arasında değil ise ortalamaya katılmasın. 
             */

            int matematikNotu;
            int fizikNotu;
            int turkceNotu;
            int kimyaNotu;
            int muzikNotu;
            int ortalamayaKatilacakDersSayisi;
            double ortalama;

            int i=5;

            Console.Write("Matematik notunuzu girin:");
            matematikNotu = Convert.ToInt16(Console.ReadLine());  

            Console.Write("Fizik notunuzu girin:");
            fizikNotu = Convert.ToInt16(Console.ReadLine());

            Console.Write("Turkce notunuzu girin:");
            turkceNotu = Convert.ToInt16(Console.ReadLine());

            Console.Write("Kimya notunuzu girin:");
            kimyaNotu = Convert.ToInt16(Console.ReadLine());

            Console.Write("Muzik notunuzu girin:");
            muzikNotu = Convert.ToInt16(Console.ReadLine());


            if (matematikNotu <= 0 || matematikNotu > 100)
            {
                matematikNotu = 0;
                i--;
            }
            if (fizikNotu <= 0 || fizikNotu > 100)
            {
                fizikNotu = 0;
                i--;
            }
            if (turkceNotu <= 0 || turkceNotu > 100)
            {
                turkceNotu = 0;
                i--;
            }
            if (kimyaNotu <= 0 || kimyaNotu > 100)
            {
                kimyaNotu = 0;
                i--;
            }
            if (muzikNotu <= 0 || muzikNotu > 100)
            {
                muzikNotu = 0;
                i--;
            }

            ortalamayaKatilacakDersSayisi = i;

            Console.WriteLine("Ortalamaya katilacak ders sayisi:"+ortalamayaKatilacakDersSayisi);

            ortalama = (matematikNotu + fizikNotu+ turkceNotu + kimyaNotu + muzikNotu) / (ortalamayaKatilacakDersSayisi);

            if (ortalama >= 55)
            {
                Console.WriteLine("Sinifi gectiniz Ortalama:"+ortalama);
            }
            else
            {
                Console.WriteLine("Sinifi gecemediniz Ortalama"+ortalama);
            }


            Console.ReadLine();

        }
    }
}