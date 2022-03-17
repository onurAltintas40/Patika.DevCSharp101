using System.Collections.Generic;

namespace TelefonRehberiProjesi
{
    public class Islem : IIslem
    {

        List<Kisi> kisiler;
       
        public Islem()
        {
            kisiler = new List<Kisi>();

            kisiler.Add(new Kisi { Adi ="Onur", Soyad="Altıntaş",TelNo="05415412323"});
            kisiler.Add(new Kisi { Adi = "Zeki", Soyad = "Atalay", TelNo = "05415412324" });
            kisiler.Add(new Kisi { Adi = "Tekin", Soyad = "Metin", TelNo = "05415412325" });
            kisiler.Add(new Kisi { Adi = "Ahmet", Soyad = "Keke", TelNo = "05415412326" });
            kisiler.Add(new Kisi { Adi = "Necmi", Soyad = "Güdük", TelNo = "05415412327" });
        }

        public List<Kisi> Listele()
        {
            return kisiler;
        }

        public Kisi Ara(Kisi kisi)
        {
            try
            {
                foreach (var item in kisiler)
                {
                    if (item.Adi == kisi.Adi || item.Soyad == kisi.Soyad)
                    {
                       return item;
                    }
                }
                return null;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public int Ekle(Kisi kisi)
        {
            try
            {
                kisiler.Add(new Kisi { Adi = kisi.Adi, Soyad = kisi.Soyad, TelNo = kisi.TelNo });
                return 1;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }

        public int Guncelle(Kisi kisi)
        {
            try
            {
                foreach (var item in kisiler)
                {
                    if (item.Adi == kisi.Adi || item.Soyad == kisi.Soyad)
                    {
                        item.Adi = kisi.Adi;
                        item.Soyad = kisi.Soyad;
                        item.TelNo = kisi.TelNo;
                    }
                }
                return 1;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
       
        public Kisi Sil(string ad,string soyad, bool sil)
        {
            try
            {
                foreach (var item in kisiler)
                {
                    if (item.Adi == ad || item.Soyad == soyad)
                    {
                        if (sil)
                        {
                            kisiler.Remove(item);
                        }
                        return item;                       
                    }                    
                }
                return null;
            }
            catch (System.Exception)
            {

                return null;
            }
        }
    }
}
