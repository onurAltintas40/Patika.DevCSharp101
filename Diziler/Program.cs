using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Kuş", "Maymun", "Köpek" };

            int[] dizi;

            dizi = new int[5];

            //Dizilere değer atama

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngüler ve dizi

            // Klavyeden girilen n tane sayının ortalamasını alan program 

            Console.Write("Lütfen dizinin eleman sayısını giriniz:");

            int diziuzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısını giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama: " + toplam / diziuzunlugu);

        }
    }
}
