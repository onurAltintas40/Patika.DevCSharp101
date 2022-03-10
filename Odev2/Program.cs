using System;
using System.Collections;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Soru 1
            /*
             * Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

               - Negatif ve numeric olmayan girişleri engelleyin.
               - Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
               - Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
             */

            ArrayList asal = new();
            ArrayList asalOlmayan = new();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("Lütfen pozitif bir sayı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz !!!");
                        i--;
                    }
                    else
                    {
                        for (int j = 2; j < sayi; j++)
                        {
                            if (sayi % j == 0)
                            {
                                asalOlmayan.Add(sayi);
                                break;
                            }
                            else
                            {
                                asal.Add(sayi);
                                break;
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz !!!");
                    i--;
                }
            }

            asal.Sort();
            asalOlmayan.Sort();
            Console.WriteLine("Asal Dizi: ");
            foreach (var item in asal)
            {
                Console.Write(" - {0}", item);
            }
            Console.WriteLine("Asal Olmayan Dizi: ");

            foreach (var item in asalOlmayan)
            {
                Console.Write(" - {0}", item);
            }

            Console.WriteLine("Asal dizi eleman sayısı: {0}", asal.Count);

            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            foreach (var item in asal)
            {
                asalToplam += (int)item;
            }

            Console.WriteLine("Asal dizi ortalaması {0}", (asalToplam / 20).ToString());

            Console.WriteLine("Asal olmayan dizi eleman sayısı: {0}", asalOlmayan.Count);

            foreach (var item in asalOlmayan)
            {
                asalOlmayanToplam += (int)item;
            }

            Console.WriteLine("Asal olmayan dizi ortalaması {0}", (asalToplam / 20).ToString());
            #endregion

            #region Soru 2

            /*
             * Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */

            ArrayList sayiListesi = new();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write("Lütfen pozitif bir sayı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz !!!");
                        i--;
                    }
                    else
                    {
                        sayiListesi.Add(sayi);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz !!!");
                    i--;
                }
            }

            sayiListesi.Sort();

            Console.WriteLine("En büyük üç sayının toplamı {0}, ortalaması {1}: ", ((int)sayiListesi[19] + (int)sayiListesi[18] + (int)sayiListesi[17]), ((int)sayiListesi[19] + (int)sayiListesi[18] + (int)sayiListesi[17]) / 3);

            Console.WriteLine("En küçük üç sayının toplamı {0}, ortalaması {1}: ", ((int)sayiListesi[0] + (int)sayiListesi[1] + (int)sayiListesi[2]), ((int)sayiListesi[0] + (int)sayiListesi[1] + (int)sayiListesi[2]) / 3);


            #endregion

            #region Soru 3

            /*
             * Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
             */


            string giris = Console.ReadLine();

            ArrayList sesliHarfler = new();

            foreach (var item in giris)
            {
                if (item =='a' || item=='e' || item == 'i' || item == 'ı' || item == 'u' || item == 'ü' || item == 'o' || item == 'ö')
                {
                    sesliHarfler.Add(item);
                }
            }

            sesliHarfler.Sort();

            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
