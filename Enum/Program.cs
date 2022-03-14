using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;

            if(sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınması bekle !!!");
            }
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak !!!");
            }
            if (sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım !!!");
            }
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soğuk = 5,
        Normal =20,
        Sıcak =25,
        ÇokSıcak = 30
    }
}
