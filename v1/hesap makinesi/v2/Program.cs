using System;

class Program
{ // kendim hata aldıgım yerden çıkamadım chatgpt den yardım aldım çok daha temiz ve mantıklı hali budur
    static void Main()
    {
        Console.WriteLine("Yapmak istediğiniz matematik işlemini seçin:");
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Çarpma");
        Console.WriteLine("4. Bölme");
        Console.Write("Seçiminizi yapın (1-4): ");
        int secim = int.Parse(Console.ReadLine());

        Console.Write("Kaç adet rakam ile işlem yapmak istiyorsunuz? ");
        int adet = int.Parse(Console.ReadLine());

        double sonuc = 0;


        Console.Write($"Lütfen 1. rakamı girin: "); // anlamadıgım kısım 1 den başlatıp asagıda devam ettirmek cumartesi arkadaşlarımla konusup hallediceğiz
        sonuc = double.Parse(Console.ReadLine());

        for (int i = 1; i < adet; i++)
        {
            Console.Write($"Lütfen {i + 1}. rakamı girin: ");
            double rakam = double.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    sonuc += rakam;
                    break;
                case 2:
                    sonuc -= rakam;
                    break;
                case 3:
                    sonuc *= rakam;
                    break;
                case 4:
                    if (rakam != 0)
                        sonuc /= rakam;
                    else
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    return;
            }
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}
