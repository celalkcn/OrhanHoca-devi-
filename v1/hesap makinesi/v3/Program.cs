namespace v3;

class Program
{

    //     - Kullanıcı rakam girip yapmak istediği işlemi seçsin.
    // Örneğin 5 girsin sonra toplama işlemi için seçim yapsın.
    // Her işlem sonrasında sonucu ekranda göstermeliyiz. // while ile yap
    // Kullanıcı "e" girmediği sürece hesaplama işlemi devam etsin !!!1 while yani 

    // eksik kısmı var hallediceğim 27.09.2024
    static void Main(string[] args)
    {
        double sonuc = 0;

        System.Console.WriteLine("bir adet rakam giriniz1");

        while (true)
        {
            System.Console.WriteLine("yapmak istediğiniz işlemi seciniz");

            System.Console.WriteLine("1.toplama");
            System.Console.WriteLine("2.cıkarma");
            System.Console.WriteLine("3.carpma");
            System.Console.WriteLine("4.bölme");

            int secim = int.Parse(System.Console.ReadLine());
            System.Console.Write("bir rakam giriniz");

            double rakam = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("baslangıc sayısı 0");

            switch (secim)
            {
                case 1:
                    sonuc += rakam;
                    System.Console.WriteLine("toplama sonucu " + sonuc);
                    break;

                case 2:
                    sonuc -= rakam;
                    System.Console.WriteLine("cıkarma sonucu " + sonuc);
                    break;

                case 3:
                    sonuc *= rakam;
                    System.Console.WriteLine("carpma sonucu " + sonuc);
                    break;

                case 4:
                    sonuc /= rakam;
                    System.Console.WriteLine("osimen sonucu " + sonuc);
                    break;





            }


            System.Console.WriteLine("hesaplama islemi bitti sonuc" + sonuc);


        }

    }
}
