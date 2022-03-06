using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Soru1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */

            Console.Write("Lütfen pozizitf bir sayı giriniz: ");
            int pozitifSayi = int.Parse(Console.ReadLine());

            Console.Write("Lütfen {0} adet sayı giriniz: ", pozitifSayi);

            for (int i = 0; i < pozitifSayi; i++)
            {
                int sayi3 = int.Parse(Console.ReadLine());

                if (sayi3 % 2 == 0)
                {
                    Console.WriteLine(sayi3 + " çift sayıdır.");
                }
                else
                {
                    Console.WriteLine(sayi3 + " tek sayıdır.");
                }
            }

            /* Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
             */

            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen {0} adet sayı giriniz: ", sayi1);

            for (int i = 0; i < sayi1; i++)
            {
                int deger = int.Parse(Console.ReadLine());

                if (deger == sayi2 || deger % sayi2 == 0)
                {
                    Console.WriteLine("Sayı: {0}", deger);
                }
                else
                {
                    Console.WriteLine(deger);
                }
            }

            /* Soru 3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
             * Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
             * Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             */

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
         
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                string kelime = Console.ReadLine();

                for (int j = kelime.Length-1; j >=0; j--)
                {
                    Console.Write(kelime[j]);
                }                
            }


            /*Soru 4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
             * Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
             */

            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            string[] cumle1 = cumle.Split(' ');

            Console.WriteLine("Kelime Sayısı: {0}", cumle1.Length);

            string cumle2 = cumle.Replace(" ", "");

            int harfSayisi = 0;

            for (int i = 0; i < cumle2.Length; i++)
            {
                harfSayisi++;
            }

            Console.WriteLine("Harf Sayısı: {0}", harfSayisi.ToString());
        }
    }
}
