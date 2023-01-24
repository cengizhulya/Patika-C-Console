using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KombinasyonHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //C(n,r) = n! / (r! * (n-r)!)

            int sayi1;
            int sayi2;
            int sayi3;
            int sonuc1=1;
            int sonuc2=1;
            int sonuc3=1;
            int kombinasyonSonuc;

            Console.Write("Kombinasyonu alinacak sayi:");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Kacli kombinasyonu alinacak:");
            sayi2 = int.Parse(Console.ReadLine());

            for(int i = sayi1; i>=1; i--)
            {
                sonuc1 = sonuc1 * i;
            }

            for (int i = sayi2; i >= 1; i--)
            {
                sonuc2 = sonuc2 * i;
            }

            sayi3 = sayi1 - sayi2;

            for (int i = sayi3; i >= 1; i--)
            {
                sonuc3 = sonuc3 * i;
            }

            kombinasyonSonuc = sonuc1 / (sonuc2 * sonuc3);

            Console.WriteLine("Sonuc:"+kombinasyonSonuc);

            Console.ReadLine();
        }
    }
}