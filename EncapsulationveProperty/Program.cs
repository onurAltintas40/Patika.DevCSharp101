using System;

namespace EncapsulationveProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new();

            ogrenci1.Isim = "Onur";
            ogrenci1.Soyisim = "Altıntaş";
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 8;

            ogrenci1.OgrenciBilgileriGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.SinifAtlat();

            ogrenci1.OgrenciBilgileriGetir();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriGetir();


            Ogrenci ogrenci2 = new("Deniz","Arda",256,1);
            ogrenci2.OgrenciBilgileriGetir();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriGetir();


        }
    }

    class Ogrenci
    {

        private string isim;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        private string soyisim;

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }

        private int ogrenciNo;

        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }

        private int sinif;

        public int Sinif
        {
            get { return sinif; }
            set 
            {
                if (value <= 1)
                {
                    sinif = 1;
                    Console.WriteLine("Sınıf 1'den düşük olamaz.");
                }
                else
                {
                    sinif = value;
                }                
            }
        }


        public Ogrenci() { }

        public Ogrenci(string isim)
        { 
            Isim = isim;
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı : {0}", isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", soyisim);
            Console.WriteLine("Öğrenci No : {0}", ogrenciNo);
            Console.WriteLine("Öğrenci Sınıf : {0}", sinif);            
        }

        public void SinifAtlat()
        {
            Sinif++;
        }

        public void SinifDusur()
        {
            Sinif--;
        }

    }
}
