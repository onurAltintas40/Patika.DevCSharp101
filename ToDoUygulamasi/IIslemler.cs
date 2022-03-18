
using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public interface IIslemler
    {
        public int Ekle(Kart kart, string x);
        public int Guncelle(Kart kart, string x);
        public int Sil(string baslik, string x);
        public int Tasi(string baslik, string x,string y);
        public List<Kart> BoardListele(string x);
    }
}
