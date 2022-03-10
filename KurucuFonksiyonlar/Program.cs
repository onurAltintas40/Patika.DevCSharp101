using System;

namespace KurucuFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new("Onur", "Altıntaş", 12345678, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new();

            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "Keke";
            calisan2.No = 87654321;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Calisan calisan3 = new();

            calisan3.Ad = "Ahmet";
            calisan3.Soyad = "Keke";            

            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan() { }

        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;         
        }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Departman: {0}", Departman);
        }
    }
}
