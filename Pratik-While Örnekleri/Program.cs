//1.Örnek:

int i = 1;// Başlangıç değeri
while (i<=10)
{
    Console.WriteLine($"Kendime inanıyorum, ben bu yazılım işini hallederim! ");
    i++;
}
 Console.ReadLine();

//2. Örnek: 1 ile 20 arasındaki sayıları konsol ekranına yazdıran program.

int i = 0;// Başlangıç değeri
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}
Console.ReadLine();

//3. Örnek:1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int i = 2;// Başlangıç değeri(Çift sayı dediği için 2'den başlıyoruz.)
while (i <= 20)
{
    Console.WriteLine(i);
    i += 2;// i'yi iki artır
}
Console.ReadLine();

//4. Örnek:50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız

int i = 50;// Başlangıç değeri
int toplam = 0;// Toplamı tutacak değişken
while (i <= 150)// 50 ile 150 arasındaki sayılar
{
    toplam += i;// i'yi toplama ekle
    i++;// i'yi bir artır
}
Console.WriteLine($"{toplam}");

//5. Örnek:1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tektoplam = 0; // Tek sayıların toplamını tutacak değişken
int çifttoplam = 0;
int i = 1;// Başlangıç değeri
while (i <= 120)// 1 ile 120 arasındaki sayılar
{
    tektoplam += i;// O anki 'i' değerini tektoplam'a ekledim.
    i += 2;// 'i' değerini 2 artır (bir sonraki tek sayıya geç)

}
Console.WriteLine($"Tek sayıların toplamı:{tektoplam}");// Sonucu ekrana yazdırdım.
Console.ReadLine();// Konsolun kapanmasını engellendi.
i = 2;// İlk çift sayı
while (i <= 120)
{
    çifttoplam += i;
    i += 2;
}
Console.WriteLine($"Çift sayıların toplamı:{çifttoplam}");// Sonucu ekrana yazdırdım.
Console.ReadLine();// Konsolun kapanmasını engellendi.
