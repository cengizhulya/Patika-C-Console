using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsluSayiHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban;
            int us;
            int us_;

            Console.Write("Ussu alinacak sayi:");
            taban = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Us:");
            us = int.Parse(Console.ReadLine());

            us_=us;

            int sonuc = 1;

            while (us >= 1)
            {
                sonuc = sonuc * taban;
                us--;
            }


            Console.WriteLine(taban+"'sayisinin "+us_+".kuvveti:"+sonuc);

            Console.ReadLine();
        }
    }
}