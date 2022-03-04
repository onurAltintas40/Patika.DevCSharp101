using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler

            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı - " + outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar ornek = new Metotlar();
            ornek.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            int ifade = 999;
            ornek.EkranaYazdir(ifade.ToString());
            ornek.EkranaYazdir("Onur Altıntaş");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri.ToString());
        }
    }
}

