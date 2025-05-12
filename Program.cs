/*
1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 1;
while (i <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
*/

/*
2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}
*/

/*
3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int i = 2;
while (i <= 20)
{
    Console.WriteLine(i);
    i += 2;
}
*/

/*4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
int i = 50;
while (i <= 150)
{
    toplam += i;
    i++;
}
Console.WriteLine("Sayıların toplamı:" + toplam);
*/

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekSayiToplam = 0;
int ciftSayiToplam = 0;
int i = 1;
while (i <= 120)
{
    if (i % 2 == 0)
    {
        ciftSayiToplam += i;
    }
    else
    {
        tekSayiToplam += i;
    }
    i++;
}
Console.WriteLine("Çift Sayıların Toplamı:" + ciftSayiToplam);
Console.WriteLine("Tek Sayıların Toplamı:" + tekSayiToplam);