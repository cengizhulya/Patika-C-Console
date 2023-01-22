string islem;

double sayi1;
double sayi2;
double sonuc;

Console.WriteLine(" ***Hesap Makinesi*** \n");

Console.Write("1.sayiyi girin:");
sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2.sayiyi girin:");
sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Yapilacak islemin numarasini secin \n");

Console.WriteLine("1-Toplama \n2-Cikarma \n3-Carpma \n4-Bolme\n");

islem = Convert.ToString(Console.ReadLine());

Console.WriteLine("");

switch (islem)
{
    case "1":
        sonuc = sayi1 + sayi2;

        Console.Write("Sonuc:" + sonuc);
        break;

    case "2":
        sonuc = sayi1 - sayi2;

        Console.Write("Sonuc:" + sonuc);
        break;

    case "3":
        sonuc = sayi1 * sayi2;

        Console.Write("Sonuc:" + sonuc);
        break;

    case "4":
        sonuc = sayi1 / sayi2;

        Console.Write("Sonuc:" + sonuc);
        break;

    default: 
        Console.WriteLine("Gecersiz islem girdiniz!!");
        break;
}

Console.ReadLine();