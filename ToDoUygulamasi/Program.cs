using System;

namespace ToDoUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            UserList userList = new UserList();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("    ### TODO Uygulaması ###\n\n");

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*****************************************\n");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak\n");


                Console.WriteLine("(0) ÇIKIŞ");

                int secim = 0;

                Console.Write("Seçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                if (secim == 0)
                {
                    break;
                }
                else if (secim == 2)
                {
                    Kart kart = new Kart();
                    Console.Write("Başlık: ");
                    kart.Baslik = Console.ReadLine();
                    Console.Write("İçerik: ");
                    kart.Icerik = Console.ReadLine();
                    Console.Write("Büyüklük (1)XS, (2)S, (3)M, (4)L, (5)XL :");
                    kart.Buyukluk = Console.ReadLine();
                    int sira = 1;
                    foreach (var item in userList.user)
                    {
                        Console.WriteLine("{0} - {1}", sira, item.Isim);
                        sira++;
                    }

                    Console.Write("Atanan Kişi: ");
                    kart.AtananKisi = Console.ReadLine();

                    Console.Write("Nereye Eklenecek (1) TODO, (2) InProgress, (3) Done: ");
                    kart.AtananKisi = Console.ReadLine();
                   
                    
                    var sonuc = islem.Ekle(kart,kart.AtananKisi);

                    if (sonuc == 1)
                    {
                        Console.WriteLine("Kayıt başarıyla eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt eklenemedi !!!");
                    }

                }
                else if (secim == 3)
                {
                    Console.Write("Başlık: ");
                    string baslik = Console.ReadLine();
                    Console.Write("Nereden Silinecek (1) TODO, (2) InProgress, (3) Done: ");
                    string x = Console.ReadLine();

                    var sonuc = islem.Sil(baslik, x);

                    if (sonuc == 0)
                    {
                        Console.WriteLine("Silinecek kayıt bulunamadı !!!");
                    }
                    else
                    { 
                        Console.WriteLine("Kayıt başaryıla silindi.");
                    }
                }
                else if (secim == 4)
                {
                    Console.Write("Başlık: ");
                    string baslik = Console.ReadLine();
                    Console.Write("Nereden Taşınacak (1) TODO, (2) InProgress, (3) Done: ");
                    string x = Console.ReadLine();
                    Console.Write("Nereye Taşınacak (1) TODO, (2) InProgress, (3) Done: ");
                    string y = Console.ReadLine();

                    var sonuc = islem.Tasi(baslik,x,y);

                    if (sonuc == 1)
                    {
                        Console.WriteLine("Kayıt başarıyla taşındı.");
                    }
                    else
                    {
                        Console.WriteLine("Taşınırken hata oluştu !!!");
                    }
                }
                else if (secim == 1)
                {
                    var sonuc1 = islem.BoardListele("1");

                    if (sonuc1 == null)
                    {
                        Console.WriteLine(" TODO Kayıt bulunamadı !!!");
                    }
                    else
                    {
                        Console.WriteLine("\t TODO Listenleniyor");
                        Console.WriteLine("*****************************");
                        foreach (var item in sonuc1)
                        {
                            Console.WriteLine("Başlık: {0}\nİçerik: {1}\nBüyüklük: {2}\nAtanan Kişi:", item.Baslik, item.Icerik, item.Buyukluk,item.AtananKisi);
                            
                        }
                    }


                    var sonuc2 = islem.BoardListele("2");

                    if (sonuc2 == null)
                    {
                        Console.WriteLine(" InProgress Kayıt bulunamadı !!!");
                    }
                    else
                    {
                        Console.WriteLine("\t InProgress Listenleniyor");
                        Console.WriteLine("*****************************");
                        foreach (var item in sonuc2)
                        {
                            Console.WriteLine("Başlık: {0}\nİçerik: {1}\nBüyüklük: {2}\nAtanan Kişi:", item.Baslik, item.Icerik, item.Buyukluk, item.AtananKisi);

                        }
                    }

                    var sonuc3 = islem.BoardListele("2");

                    if (sonuc3 == null)
                    {
                        Console.WriteLine(" Done Kayıt bulunamadı !!!");
                    }
                    else
                    {
                        Console.WriteLine("\t Done Listenleniyor");
                        Console.WriteLine("*****************************");
                        foreach (var item in sonuc3)
                        {
                            Console.WriteLine("Başlık: {0}\nİçerik: {1}\nBüyüklük: {2}\nAtanan Kişi:", item.Baslik, item.Icerik, item.Buyukluk, item.AtananKisi);

                        }
                    }
                }
            }
        }
    }
}
