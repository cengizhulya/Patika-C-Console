/*
Ödev 1
Dik Üçgende Hipotenüs Bulan Program
Java ile kullanıcıdan dik kenarlarının uzunluğunu alan ve hipotenüsü hesaplayan programı yazın.

Ödev 2
Üç kenar uzunluğunu kullanıcıdan aldığınız üçgenin alanını hesaplayan programı yazınız.
Formül
Üç𝑔𝑒𝑛𝑖𝑛 ç𝑒𝑣𝑟𝑒𝑠𝑖 = 2𝑢

𝑢 = (a+b+c) / 2

Alan * Alan = 𝑢 * (𝑢 − 𝑎)* (𝑢 − 𝑏) * (𝑢 − 𝑐)
*/

/* Ödev 1
double kenar1;
double kenar2;
double kenarlarınKareleriToplami;
double hipotenus;

Console.Write("Dik ucgenin kenarlarindan birinicisini girin:");
kenar1 =int.Parse(Console.ReadLine());

Console.Write("Dik ucgenin kenarlarindan ikincisini girin:");
kenar2=int.Parse(Console.ReadLine());

kenarlarınKareleriToplami = (kenar1 * kenar1)+(kenar2*kenar2);

hipotenus = Math.Sqrt(kenarlarınKareleriToplami);

Console.WriteLine("Hipotenus="+hipotenus);

Console.ReadLine(); 
*/

// Ödev 2

double kenar1;
double kenar2;
double kenar3;
double ucgeninCevresininYarisi;
double ucgeninCevresi;
double alan;

Console.Write("Ucgenin kenarlarindan birinicisini girin:");
kenar1 = int.Parse(Console.ReadLine());

Console.Write("Ucgenin kenarlarindan ikincisini girin:");
kenar2 = int.Parse(Console.ReadLine());

Console.Write("Ucgenin kenarlarindan ucuncusunu girin:");
kenar3 = int.Parse(Console.ReadLine());

ucgeninCevresi = kenar1 + kenar2 + kenar3;

ucgeninCevresininYarisi = ucgeninCevresi / 2;

alan = Math.Sqrt(ucgeninCevresininYarisi *(ucgeninCevresininYarisi - kenar1)* (ucgeninCevresininYarisi - kenar2)* (ucgeninCevresininYarisi - kenar3));

Console.WriteLine(alan);

Console.ReadLine();