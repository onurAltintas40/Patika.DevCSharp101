using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new();

            calisan1.Ad = "Onur";
            calisan1.Soyad = "Altıntaş";
            calisan1.No = 12345678;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new();

            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "Keke";
            calisan2.No = 87654321;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();            
        }
    }


    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;        

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Adı: {0}", Soyad);
            Console.WriteLine("Çalışan Adı: {0}", No);
            Console.WriteLine("Çalışan Adı: {0}", Departman);
        }
    }
}
