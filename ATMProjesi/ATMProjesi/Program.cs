using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi = "a";
            int sifre = 123;

            int islem;

            int hak = 3;

            int bakiye=1000;

            int yatirilacakPara;

            int cekilecekPara;

            bool kontrol;

            Console.Write("                 XXX BANKASI \n");

            while(hak >= 1)
            {
                Console.Write("Kullanici adinizi girin:");
                kullaniciadi = Console.ReadLine();

                Console.Write("Sifrenizi girin:");
                sifre = int.Parse(Console.ReadLine());

                if (kullaniciadi == "a" && sifre == 123)
                {
                    Console.WriteLine("Giris yapildi");
                    break;
                }
                else
                {
                    Console.WriteLine("Girilen bilgiler yanlis");
                    hak--;
                }

            }

            if(hak == 0)
            {
                Console.WriteLine("Hesabiniz bloke olmustur banka ile iletisime gecin.");
                
            }


            while (true)
            {

                Console.WriteLine(" ***Islemler*** \n 1-Para Yatirma \n 2-Para Cekme \n 3-Bakiye Sorgulama \n 4-Cikis Yap");

                Console.Write("Yapilacak islemin numarasini girin:");
                islem = int.Parse(Console.ReadLine());

                switch (islem)
                {
                        case 1:
                    Console.Write("Yatirilacak para miktarini girin:");
                    yatirilacakPara = int.Parse(Console.ReadLine());
                    bakiye = bakiye + yatirilacakPara;
                    Console.WriteLine("Yeni bakiye:"+bakiye);
                        break;

                        case 2:
                        
                        Console.Write("Cekilecek para miktarini girin:");
                        cekilecekPara = int.Parse(Console.ReadLine());

                        if (cekilecekPara > bakiye)
                        {
                            Console.Write("Cekilecek para, bakiyeden fazla olamaz. \n");
                            Console.Write("Cekilecek para miktarini girin:");
                            cekilecekPara = int.Parse(Console.ReadLine());

                        }

                        bakiye = bakiye - cekilecekPara;
                        Console.WriteLine("Kalan bakiye:" + bakiye);
                        break ;

                        case 3:
                        {
                            Console.WriteLine("Bakiye:" + bakiye);
                        }
                        break ;

                    case 4:

                        Console.WriteLine("Cikis yapildi. Iyi gunler.");
                        break;
                
                }
            }

            Console.ReadLine();
        }
    }
}