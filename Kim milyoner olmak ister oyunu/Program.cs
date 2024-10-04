using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bilgi Yarışmasına Hoş Geldiniz!");//Verilen metni ekrana yazdırır.
        int dogrusayısı = 0;// Doğru sayısı adında bir tamsayı değerini atar.

        Console.WriteLine("1)Türkiye’nin yüzölçümü kaç kilometre karedir?");//Verilen metni ekrana yazdırır.
        Console.WriteLine("a)779.452 \nb)546.432");// Verilen şıkları ekrana yazdırır.
        string cevap1 = Console.ReadLine();// Girilen şıkkı ekranda görmemizi sağlar.

        if (cevap1 == "a")// Eğer kullanıcı cevap1 değişkenine "a" değerini girdiyse, aşağıdaki kod bloğu çalışır.
        {
            Console.WriteLine("Doğru cevap!");// Ekrana "Doğru cevap!" yazdırır.
            dogrusayısı++;// dogrusayısı değişkenininin değerini 1 arttırır.

        }
        else
        {
            Console.WriteLine("Yanlış cevap!");// Diğer şık seçilirse ekrana "Yanlış cevap!" yazdırır.
        }


        Console.WriteLine("2)Dünyanın ters yöne akan tek nehri hangisidir?");//Verilen metni ekrana yazdırır.
        Console.WriteLine("a)Asi Nehri \nb)Nil Nehri");// Verilen şıkları ekrana yazdırır.
        string cevap2 = Console.ReadLine();// Girilen şıkkı ekranda görmemizi sağlar.

        if (cevap2 == "a")// Eğer kullanıcı cevap1 değişkenine "a" değerini girdiyse, aşağıdaki kod bloğu çalışır.
        {
            Console.WriteLine("Doğru cevap!");// Ekrana "Doğru cevap!" yazdırır.
            dogrusayısı++;// dogrusayısı değişkenininin değerini 1 arttırır.

        }
        else
        {
            Console.WriteLine("Yanlış cevap!");// Diğer şık seçilirse ekrana "Yanlış cevap!" yazdırır.
        }

        Console.WriteLine("3)İnci Küpeli Kız tablosu kime aittir?");
        Console.WriteLine("a)Vincent van Gogh \nb)Johannes Vermeer");
        string cevap3 = Console.ReadLine();

            if (cevap3 == "b")
            {
                Console.WriteLine("Doğru cevap!");// Eğer kullanıcı cevap1 değişkenine "b" değerini girdiyse, aşağıdaki kod bloğu çalışır.
            dogrusayısı++;// dogrusayısı değişkenininin değerini 1 arttırır.
        }
            else
            {
                Console.WriteLine("Yanlış cevap!");// Diğer şık seçilirse ekrana "Yanlış cevap!" yazdırır.

        }


        Console.WriteLine("\nYarışma Bitti! Toplam Doğru Sayınız: " + dogrusayısı);//\n karakteri,yeni bir satır açarak cümleyi yazdırır. dogrusayısı değişkenini cümlenin sonuna yazdırır.
    


            if (dogrusayısı == 2 || dogrusayısı == 3)// dogrusayısı değeri 2 veya(||) 3 çıkarsa bu blok çalışır.
        {
                Console.WriteLine("1 milyon TL kazandınız!");//Ekrana metni yazdırır.
            }
       

    }
            }
