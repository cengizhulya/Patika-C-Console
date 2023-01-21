/*Dairenin Alanını ve Çevresini Hesaplayan Program
Java ile yarı çapını kullanıcıdan aldığınız dairenin alanını ve çevresini hesaplayan programı yazın.

Alan Formülü : π* r * r;

Çevre Formülü : 2 * π * r;
*/

using System.Data;

Console.WriteLine("***Dairenin Alanini ve Cevresini Hesaplayan Program*** /n");

double yariCap;
double alan;
double cevre;
double pi;

pi = 3;

Console.Write("Dairenin yari capini girin:");
yariCap = double.Parse(Console.ReadLine());    

alan = pi*yariCap*yariCap;

cevre = 2 * pi * yariCap;

Console.WriteLine("Dairenin alani: "+alan);
Console.WriteLine("Dairenin cevresi:"+cevre);

Console.WriteLine("Yarıçapı r, merkez açısının ölçüsü a olan daire diliminin alanı bulan program");

/*
Ödev
Yarıçapı r, merkez açısının ölçüsü 𝛼 olan daire diliminin alanı bulan programı yazınız.

𝜋 sayısını = 3.14 alınız.

Formül : (𝜋 *(r * r) * 𝛼) / 360 
*/

double yariCap2;
double merkezAci;
double daireAlan;
double piSayisi;

piSayisi = 3.14;

Console.Write("Dairenin yari capini girin:");
yariCap2 = double.Parse(Console.ReadLine());

Console.Write("Dairenin merkez acisini girin:");
merkezAci = double.Parse(Console.ReadLine());

daireAlan = (piSayisi*(yariCap2*yariCap2*merkezAci)/360);

Console.Write("Daire'nin alani: "+daireAlan);

Console.ReadLine();