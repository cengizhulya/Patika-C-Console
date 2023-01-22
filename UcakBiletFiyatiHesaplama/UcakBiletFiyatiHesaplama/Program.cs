using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletFiyatiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Mesafeye ve şartlara göre uçak bileti fiyatı hesaplayan programı yapın. Kullanıcıdan Mesafe (KM), 
             yaşı ve yolculuk tipi (Tek Yön, Gidiş-Dönüş) bilgilerini alın.Mesafe başına ücret 0,10 TL / km olarak alın.İlk olarak uçuşun toplam fiyatını hesaplayın ve 
             sonrasında ki koşullara göre müşteriye aşağıdaki indirimleri uygulayın ;

            Kullanıcıdan alınan değerler geçerli (mesafe ve yaş değerleri pozitif sayı, yolculuk tipi ise 1 veya 2) olmalıdır.
            Aksi takdirde kullanıcıya "Hatalı Veri Girdiniz!" şeklinde bir uyarı verilmelidir.
            Kişi 12 yaşından küçükse bilet fiyatı üzerinden %50 indirim uygulanır.
            Kişi 12-24 yaşları arasında ise bilet fiyatı üzerinden %10 indirim uygulanır.
            Kişi 65 yaşından büyük ise bilet fiyatı üzerinden %30 indirim uygulanır.
            Kişi "Yolculuk Tipini" gidiş dönüş seçmiş ise bilet fiyatı üzerinden %20 indirim uygulanır.
            */

            Console.WriteLine(" ***Bilet Ucreti Hesaplama***");
           
            double gidilecekMesafe;
            double biletUcreti;
            int yas;
            int yolculukTipi;

            Console.Write("Gidilecek mesafeyi KM cinsinden girin:");
            gidilecekMesafe  = Convert.ToDouble(Console.ReadLine());
            if (gidilecekMesafe <= 0)
            {
                Console.WriteLine("Hatali veri girdiniz!");
            }

            biletUcreti = gidilecekMesafe * (0.10);

            Console.Write("Yasinizi girin:");
            yas = int.Parse(Console.ReadLine());
            if (yas <= 0)
            {
                Console.WriteLine("Hatali veri girdiniz!");
            }

            Console.Write("Yolculuk tipinizi secin: 1-Tek Yon 2-Gidis Donus:");
            yolculukTipi=Convert.ToInt16(Console.ReadLine());
            if (!(yolculukTipi == 1 || yolculukTipi == 2))
            {
                Console.WriteLine("Hatali veri girdiniz!");
            }

            if (yas <= 12)
            {
                biletUcreti = biletUcreti / 2;
            }
            else if (yas >12 && yas <= 24)
            {
                biletUcreti = biletUcreti - (biletUcreti * (10 / 100));
            }
            else if (yas > 65)
            {
                biletUcreti = biletUcreti - (biletUcreti * (30 / 100));
            }

            if (yolculukTipi == 2)
            {
                biletUcreti = biletUcreti - (biletUcreti * (20 / 100));
            }

            Console.WriteLine("Bilet ucreti:{0} TL",biletUcreti);

            Console.ReadLine();
        }
    }
}
