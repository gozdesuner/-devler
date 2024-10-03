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
        decimal fiyat = 0;// decimal genellikle para birimlerinde kullanılır.

        switch (meyve)//switch komutu meyve değişkenine göre hangi kodun çalıştıralacağına karar verir.
        {
            case "elma"://Bu case göre kullanıcı elma seçerse bukısım çalışır. hangi case'teki meyveyi saçerse o bloğu çalıştırır.
                fiyat = 25;//fiyat değişkenini atar.
                break;//break komutuyla durumu işler switc yapısından çıkmasını sağlar.Break önemlidir kullanılmazsa diğer caselerdede döner.
            case "armut":
                fiyat = 35;
                break;
            case "çilek":
                fiyat = 25;
                break;
            case "muz":
                fiyat = 35;
                break;
            default:
                fiyat = 50;
                break;
        }
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{fiyat} TL");//Kullanıcının seçtiği meyvenin fiyatını ekrana yazdırır.$ imleci {} içindeki ifadeleri yerleştirir.


                }
        
        }


    
