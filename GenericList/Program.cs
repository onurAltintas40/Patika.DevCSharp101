using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List Foreach ile elemanlara erişimi
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 listede bulundu");
            }

            //eleman ile indexe ulaşma

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List tipine çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Tüm listeyi temizle

            hayvanListesi.Clear();


            //Liste içerisinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isım = "Onur";
            kullanici1.Soyad = "Altıntaş";
            kullanici1.Yas = 35;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isım = "Ahmet";
            kullanici2.Soyad = "Keke";
            kullanici2.Yas = 36;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine(kullanici.Isım);
                Console.WriteLine(kullanici.Soyad);
                Console.WriteLine(kullanici.Yas);
            }

            kullaniciListesi.Clear();
        }
    }

    public class Kullanicilar
    {
       
        private string isim;

        public string Isım
        {
            get { return isim; }
            set { isim = value; }
        }

        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        private int yas;

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }


    }
}
