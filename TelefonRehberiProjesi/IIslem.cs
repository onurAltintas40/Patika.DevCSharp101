

using System.Collections.Generic;

namespace TelefonRehberiProjesi
{
    public  interface IIslem
    {
        public int Ekle(Kisi kisi);
        public int Guncelle(Kisi kisi);
        public Kisi Sil(string ad, string soyad, bool sil);
        public List<Kisi> Listele();
        public Kisi Ara(Kisi kisi);        
    }
}
