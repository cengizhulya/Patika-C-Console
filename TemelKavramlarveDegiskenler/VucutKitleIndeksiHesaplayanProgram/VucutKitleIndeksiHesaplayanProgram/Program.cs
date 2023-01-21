/*
Vücut Kitle İndeksi Hesaplama
Java ile kullanıcıdan boy ve kilo değerlerini alıp bir değişkene atayın. Aşağıdaki formüle göre kullanıcının "Vücut Kitle İndeks" değerini hesaplayıp ekrana yazdırın.

Formül
Kilo (kg) / Boy(m) * Boy(m)
*/

Console.WriteLine("    ***Vucut Kitle Indeksi Hesaplama*** /n");

double boy;
double kilo;
double vucutKitleIndeksi;

Console.Write("Boyunuzu metre cinsinden girin:");
boy = Convert.ToDouble(Console.ReadLine());

Console.Write("Kilonuzu kilogram cinsinden girin:");
kilo = Convert.ToDouble(Console.ReadLine());


vucutKitleIndeksi = (kilo / (boy * boy));
Console.Write("Vucut kitle indeksiniz:"+vucutKitleIndeksi);

Console.ReadLine();