using System;
using System.Collections;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

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
                    if (sayi<=0)
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
                Console.Write(" - {0}",item);
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

        }
    }
}
