using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDVTutariHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double para;
            double sonFiyat;
            double kdvOrani;
            double kdv;

            Console.Write("Para tutarini girin: ");
            para = Convert.ToDouble(Console.ReadLine());

            
            if (para >= 1000)
            {
                kdvOrani = (8.0);
                Console.WriteLine("KDV'siz fiyat:" + para);
                kdv = (para * kdvOrani)/100;
                Console.WriteLine("KDV tutari:" + kdv);
                sonFiyat = kdv + para;
                Console.WriteLine("KDV'li fiyat:" + sonFiyat);
            }
            else if (para >= 0 && para <= 1000)
            {
                kdvOrani = (18.0);
                Console.WriteLine("KDV'siz fiyat:" + para);
                kdv = (para * kdvOrani)/100;
                Console.WriteLine("KDV tutari:" + kdv);
                sonFiyat = kdv + para;
                Console.WriteLine("KDV'li fiyat:" + sonFiyat);
            }
            else
            {
                Console.WriteLine("Girilen tutar yanlis");
            }

            Console.ReadLine();

        }
    }
}