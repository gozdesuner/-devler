//1. Örnek:Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdıran kod.

int i = 1;
for(int i=1;i<=10;i++)
{
    Console.WriteLine($"Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//2. Örnek:1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };// Tamsayı türünde bir dizi tanımladım.

for (int i = 0; i < sayilar.Length; i++) // Bu, dizinin her elemanına sırayla ulaşmak için kullanılan bir döngüdür.
{
    Console.WriteLine($"{sayilar[i]}");//Dizide o anki elemanı ekrana yazdırır.
}

//3. Örnek:1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
for (int i = 2; i <= 20; i += 2) // Dizideki elemanlar üzerinden geçer
{
    Console.WriteLine(i);
}

//4. Örnek:50 ile 150 arasındaki sayıların toplamını ekrana yazdıran kod.

int toplam = 50;// Toplam değerini tutacak bir değişken girdim ve başlangıç noktası 50 değerindedir.
for (int i = 50; i <= 150; i += 1) // Bu döngüde başlangıç değeri 50 olan ve 150 değerine kadar 1'er 1'er arttırdım.
{
    toplam += i; //Bu döngü her adımda i değişkenini alıp toplam değişkenine ekler.
}
Console.WriteLine($"toplam:{toplam}");//Sonucu ekrana yazdırır.

//5. Örnek: Bu kod, 1 ile 120 arasındaki çift ve tek sayıların toplamını iki ayrı döngü ile hesaplıyor ve ekrana yazdırıyor.

int i = 1;
int çifttoplam = 0;//Çift sayıların toplamını tutacak bir değişken oluşturdum.

for (i = 2; i <= 120; i += 2)//Çift sayıları toplamak için bir döngü oluşturdum.
{
    çifttoplam += i;//Her döngü adımında,o anki 'i' değeri çifttoplam'a ekleniyor.
}
Console.WriteLine($"Çift sayıların toplamı:{çifttoplam}");// Ekrana bu toplam değerini yazdırması için gerkli kod.

int tektoplam = 0;// Tek sayıların toplamını tutacak bir değişken oluşturuluyor.

for (i = 1; i <= 120; i += 2)// Tek sayıları toplamak için döngü
{
    tektoplam += i;// Her döngü adımında, o anki 'i' değeri tektoplam'a ekleniyor.
}
Console.WriteLine($"Tek sayıların toplamı:{tektoplam}");// Sonuç ekrana yazdırılıyor.