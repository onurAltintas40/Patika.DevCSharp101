using System;

namespace Diziler2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("**** Sırasız Dizi ****");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("**** Sıralı Dizi ****");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("**** Array Clear ****");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Dizinin Elemanlarının Sırasını Tersine Çevir ****");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** IndexOf ****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("**** Diziyi yeniden boyutlandır ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

        }
    }
}
