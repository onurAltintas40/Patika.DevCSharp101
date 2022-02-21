using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for Döngüsü

            // Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            /*
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Değer: " + i);
                }
            }

            int tekToplam=0, ciftToplam=0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //break, continue


            for (int i = 1; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);               
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }
            */

            // While Döngüsü
            // 1'den başlayarak girilen sayıya kadar (dahil) ortalama hesaplayıp konsola yazdıran program.

            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            int sayac = 1;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama:" + toplam / sayi);

            char karakter= 'a';
            while (karakter<'z')
            {
                Console.Write(karakter);
                karakter++;
            }

            Console.WriteLine(karakter);

            string[] arabalar = { "BMW", "Audi", "Mazda", "Opel" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }


        }
    }
}
