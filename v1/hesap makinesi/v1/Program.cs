namespace v1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç adet rakam toplamak istiyorsunuz? ");
        int adet = int.Parse(Console.ReadLine());

        double toplam = 0;

        for (int i = 0; i < adet; i++)
        {
            System.Console.Write($"{i + 1}. rakamı giriniz");
            int rakam = int.Parse(System.Console.ReadLine());
            toplam += rakam;

        }

        double ortalama = toplam / adet;
        System.Console.WriteLine($"toplam = {toplam} \nortalama = {ortalama}");

    }
}
