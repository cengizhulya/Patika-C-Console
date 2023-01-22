using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaSicakliginaGoreEtkinlikOnerme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
        Koşullar:
            Sıcaklık 5'dan küçük ise "Kayak" yapmayı öner.
            Sıcaklık 5 ve 15 arasında ise "Sinema" etkinliğini öner.
            Sıcaklık 15 ve 25 arasında ise "Piknik" etkinliğini öner.
            Sıcaklık 25'ten büyük ise "Yüzme" etkinliğini öner.
            */

            int sicaklik;

            Console.WriteLine(" ***Hava Sicakligina Gore Etkinlik Onerme Programi*** \n");

            Console.Write("Hava sicakligini girin:");
            sicaklik = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (sicaklik < 5)
            {
                Console.WriteLine("Kayak yapabilirisin");
            }
            else if(sicaklik>5 && sicaklik < 15)
            {
                Console.WriteLine("Sinemaya gidebilirsin");
            }
            else if(sicaklik>15 && sicaklik < 25)
            {
                Console.WriteLine("Piknik yapmaya gidebilirsin");
            }
            else if(sicaklik>25)
            {
                Console.WriteLine("Yüzmeye gidebilirsin");
            }

            Console.ReadLine();

            }

        }
    }
