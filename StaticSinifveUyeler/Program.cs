﻿using System;

namespace StaticSinifveUyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Onur","Altıntaş","IK");
            Calisan calisan1 = new Calisan("Onur", "Altıntaş", "IK");
            Calisan calisan2= new Calisan("Onur", "Altıntaş", "IK");
            Calisan calisan3 = new Calisan("Onur", "Altıntaş", "IK");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

           
            

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(100, 200));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi
        {
            get { return calisanSayisi; }
            set { calisanSayisi = value; }
        }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }

    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
