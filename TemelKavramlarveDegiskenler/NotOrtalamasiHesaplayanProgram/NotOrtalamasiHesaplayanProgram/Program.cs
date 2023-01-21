using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtalamasiHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Not Ortalamasi Hesaplayan Program ***");

            int matNot;
            int fizikNot;
            int kimyaNot;
            int turkceNot;
            int tarihNot;
            int muzikNot;
            int toplam;
            double ortalama;
            string sorgu;
            Console.Write("Matematik sinav puaninizi girin:");
            matNot = int.Parse(Console.ReadLine());

            Console.Write("Fizik sinav puaninizi girin:");
            fizikNot = int.Parse(Console.ReadLine());

            Console.Write("Kimya sinav puaninizi girin:");
            kimyaNot = int.Parse(Console.ReadLine());

            Console.Write("Turkce sinav puaninizi girin:");
            turkceNot = int.Parse(Console.ReadLine());

            Console.Write("Tarih sinav puaninizi girin:");
            tarihNot = int.Parse(Console.ReadLine());

            Console.Write("Muzik sinav puaninizi girin:");
            muzikNot = int.Parse(Console.ReadLine());

            toplam = matNot + fizikNot + kimyaNot + turkceNot + tarihNot + muzikNot;

            ortalama = toplam / 6;

            Console.WriteLine("Ortalama: "+ortalama);

            sorgu = (ortalama >= 60) ? "Gectiniz" : "Kaldiniz";

            Console.WriteLine(sorgu);

            Console.ReadLine();
          


            

        }
    }
}