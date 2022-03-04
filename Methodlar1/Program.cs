using System;

namespace Methodlar1
{
    class Program
    {
        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }


        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);

            Console.WriteLine(sonuc);

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdir(sonuc.ToString());
            int sonuc2 = ornek.ArtirveTopla(ref a, ref b);

            Console.WriteLine(sonuc2);
        }
    }

    class Methodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArtirveTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2;
        }
    }
}
