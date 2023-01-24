using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Faktoriyeli alinacak sayiyi girin:");
            sayi = int.Parse(Console.ReadLine());

            int sonuc = 1;

            for (int i= sayi; i >=1; i--)
            {
                sonuc = sonuc * i;

            }

            Console.WriteLine("{0} sayisinin faktoriyeli:"+sonuc,sayi);

            Console.ReadLine();

        }
    }
}