using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Odev
Eğer şifre yanlış ise kullanıcıya şifresini sıfırlayıp sıfırlamayacağını sorun, 
eğer kullanıcı sıfırlamak isterse yeni girdiği şifrenin hatalı girdiği ve unuttuğu şifre ile aynı olmaması gerektiğini kontrol edip,
şifreler aynı ise ekrana "Şifre oluşturulamadı, lütfen başka şifre giriniz." sorun yoksa "Şifre oluşturuldu" yazan programı yazınız. 
           */

            string kullaniciAdi;
            string sifre;

            int kalanHak = 5;

            while (kalanHak > 0)
            {
                Console.Write("Kullanici adinizi girin:");
                kullaniciAdi = Console.ReadLine();

                Console.Write("Sifrenizi girin:");
                sifre = Console.ReadLine();

                if (kullaniciAdi == "admin"&& sifre == "123")
                {
                    Console.WriteLine("Giris basarili");
                    break;
                }

                else if (kullaniciAdi == "admin" && sifre != "123")
                {
                    Console.WriteLine("Sifre yanlis");
                    kalanHak--;
                    Console.WriteLine("Kalan hak:"+(kalanHak));
                }

                else if (kullaniciAdi != "admin" && sifre == "123")
                {
                    Console.WriteLine("Kullanici adi veya sifre yanlis");
                    kalanHak--;
                    Console.WriteLine("Kalan hak:" + (kalanHak));
                }

                else if (kullaniciAdi != "admin" && sifre != "123")
                {
                    Console.WriteLine("Kullanici adi veya sifre yanlis");
                    kalanHak--;
                    Console.WriteLine("Kalan hak:" + (kalanHak));
                }

            }

            Console.WriteLine("Hakkiniz dolmustur");

            Console.ReadLine();


          


        }
    }
}
