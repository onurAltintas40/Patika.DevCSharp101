

using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class Islemler : IIslemler
    {

        List<Kart> TODO = new List<Kart>();

        List<Kart> InProgress = new List<Kart>();

        List<Kart> Done = new List<Kart>();

        public Islemler()
        {
            TODO.Add(new Kart { Baslik = "Ödev 2", Icerik = "Patika.dev C#101 ödevini yap", AtananKisi = "Onur", Buyukluk = Buyukluk.XS.ToString() });
            InProgress.Add(new Kart { Baslik = "Ödev 2", Icerik = "Patika.dev C#101 ödevini yap", AtananKisi = "Onur", Buyukluk = Buyukluk.XS.ToString() });
            Done.Add(new Kart { Baslik = "Ödev 2", Icerik = "Patika.dev C#101 ödevini yap", AtananKisi = "Onur", Buyukluk = Buyukluk.XS.ToString() });
        }
        public int Ekle(Kart kart, string x)
        {
            if(x=="1")
            {
                TODO.Add(new Kart { Baslik =kart.Baslik, Icerik =kart.Icerik, AtananKisi = kart.AtananKisi, Buyukluk = Buyukluk.XS.ToString() });
                return 1;
            }
            else if(x=="2")
            {
                InProgress.Add(new Kart { Baslik = kart.Baslik, Icerik = kart.Icerik, AtananKisi = kart.AtananKisi, Buyukluk = Buyukluk.XS.ToString() });
                return 1;
            }
            else if (x == "3")
            {
                Done.Add(new Kart { Baslik = kart.Baslik, Icerik = kart.Icerik, AtananKisi = kart.AtananKisi, Buyukluk = Buyukluk.XS.ToString() });
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Guncelle(Kart kart, string x)
        {
            if (x == "1")
            {
                foreach (var item in TODO)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        item.Baslik = kart.Baslik;
                        item.Icerik = kart.Icerik;
                        item.Buyukluk = kart.Buyukluk;
                        item.AtananKisi = kart.AtananKisi;
                    }
                }
                return 1;
            }
            else if (x == "2")
            {
                foreach (var item in InProgress)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        item.Baslik = kart.Baslik;
                        item.Icerik = kart.Icerik;
                        item.Buyukluk = kart.Buyukluk;
                        item.AtananKisi = kart.AtananKisi;
                    }
                }
                return 1;
            }
            else if (x == "3")
            {
                foreach (var item in Done)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        item.Baslik = kart.Baslik;
                        item.Icerik = kart.Icerik;
                        item.Buyukluk = kart.Buyukluk;
                        item.AtananKisi = kart.AtananKisi;
                    }
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Sil(string baslik, string x)
        {
            if (x == "1")
            {
                foreach (var item in TODO)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        TODO.Remove(item);
                    }
                }
                return 1;
            }
            else if (x == "2")
            {
                foreach (var item in InProgress)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        TODO.Remove(item);
                    }
                }
                return 1;
            }
            else if (x == "3")
            {
                foreach (var item in Done)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        TODO.Remove(item);
                    }
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Tasi(string baslik, string x, string y)
        {
            if (x == "1")
            {
                foreach (var item in TODO)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        if (y == "2")
                        {
                            InProgress.Add(item);
                            TODO.Remove(item);
                        }
                        else if (y == "3")
                        {
                            Done.Add(item);
                            TODO.Remove(item);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
            else if (x == "2")
            {
                foreach (var item in InProgress)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        if (y == "1")
                        {
                            TODO.Add(item);
                            InProgress.Remove(item);
                        }
                        else if (y == "3")
                        {
                            Done.Add(item);
                            InProgress.Remove(item);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
            else if (x == "3")
            {
                foreach (var item in Done)
                {
                    if (item.Baslik == item.Baslik)
                    {
                        if (y == "1")
                        {
                            TODO.Add(item);
                            Done.Remove(item);
                        }
                        else if (y == "2")
                        {
                            InProgress.Add(item);
                            Done.Remove(item);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public List<Kart> BoardListele(string x)
        {
            if (x == "1")
            {
                return TODO;
            }
            else if (x == "2")
            {
               return InProgress
            }
            else if (x == "3")
            {
               return Done
            }
            else
            {
                return null;
            }
        }

    }
}
