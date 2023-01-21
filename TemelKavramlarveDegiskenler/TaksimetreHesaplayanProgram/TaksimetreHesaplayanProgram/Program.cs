/*+
 Taksimetre Programı
Java ile gidilen mesafeye (KM) göre taksimetre tutarını ekrana yazdıran programı yazın.

Taksimetre KM başına 2.20 TL tutmaktadır.
Minimum ödenecek tutar 20 TL'dir. 20 TL altında ki ücretlerde yine 20 TL alınacaktır.
Taksimetre açılış ücreti 10 TL'dir.
*/

double acilisUcreti;
double gidilenKM;
double taksimetre;

acilisUcreti = 10;

Console.Write("Gidilen mesafeyi KM cinsinden girin:");
gidilenKM = double.Parse(Console.ReadLine());

taksimetre = gidilenKM * (2.20) + acilisUcreti;

if (taksimetre < 20)
{
    Console.Write("Odenecek ucret:"+20);
}

Console.Write("Odenecek ucret:"+taksimetre);

Console.ReadLine();