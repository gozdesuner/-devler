using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rüya Manavina Hos Geldiniz!");
        Console.WriteLine("Elma=25 TL");
        Console.WriteLine("Armut=35 TL");
        Console.WriteLine("Çilek=25TL");
        Console.WriteLine("Muz=35TL");
        Console.WriteLine("Diğer bütün meyveler=50TL");// console.Writeline yanındaki parantez içindeki yazıların ekrana yazdırılmasını sağladı.

        Console.WriteLine($"Hangi meyveyi almak istersiniz?: ");// Bu komut ekrana yazı yazdırır ancak önündeki $ imleci bir sonraki satıra geçirmez.Hangi meyvenin istendiğini sorar.
        string meyve = Console.ReadLine().ToLower();// Girilen meyveyi küçük harfe çevirir.
        decimal fiyat = 0; // decimal genellikle para birimlerinde kullanılır.

        if (meyve == "elma")// Meyve elma seçilirse burası çalışır.
        {
            fiyat = 25;// Elma fiyatının 25 TL olduğunu atar.
        }
        else if (meyve=="armut")//Seçilen meyve armut,çilek veya muz ise else if bloğu çalışmaya başlar.
        {
            fiyat = 35;
        }
        else if (meyve=="çilek")
        {
            fiyat = 25;
        }
        else if (meyve=="muz")
        {
            fiyat = 35;
        }
        else //Bu meyveler dışında başka bir meyve seçilirse bu blok çalışır.
        {
            fiyat = 50;
        }
        Console.WriteLine($"Seçtiğiniz meyve: {meyve}, Fiyatı: {fiyat} TL");//Seçilen meyvenin fiyatı ekrana yazdırırlır.
    }
}