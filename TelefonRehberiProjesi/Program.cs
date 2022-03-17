using System;

namespace TelefonRehberiProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("    ### Telefon Rehberi Projesi ###\n\n");

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*****************************************\n");
                Console.WriteLine("(1) Yeni Numara Kaydet");
                Console.WriteLine("(2) Kayıtlı Numara Sil");
                Console.WriteLine("(3) Kayıtlı Numarayı Güncelle");
                Console.WriteLine("(4) Rehberi Listele");
                Console.WriteLine("(5) Rehberde Arama Yap\n");

                Console.WriteLine("(0) ÇIKIŞ");

                int secim = 0;

                Console.Write("Seçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                if (secim == 0)
                {
                    break;
                }
                else if (secim == 1)
                {
                    Kisi kisi = new Kisi();
                    Console.Write("Adı: ");
                    kisi.Adi = Console.ReadLine();
                    Console.Write("Soyadı: ");
                    kisi.Soyad = Console.ReadLine();
                    Console.Write("Telefon No: ");
                    kisi.TelNo = Console.ReadLine();
                   
                    var sonuc = islem.Ekle(kisi);

                    if (sonuc == 1)
                    {
                        Console.WriteLine("Kayıt başarıyla eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt eklenemedi !!!");
                    }
                    
                }
                else if (secim == 2)
                {
                    Console.Write("Silinecek kişinin adı: ");
                    string adi = Console.ReadLine();
                    Console.Write("Silinecek kişisinin soyadı: ");
                    string soyad = Console.ReadLine();
                   
                    var sonuc = islem.Sil(adi, soyad, false);

                    if (sonuc == null)
                    {
                        Console.WriteLine("Silinecek kayıt bulunamadı !!!");
                    }
                    else
                    {
                        islem.Sil(adi, soyad, true);
                        Console.WriteLine("Kayıt başaryıla silindi.");
                    }                    
                }
                else if (secim == 3)
                {
                    Kisi kisi = new Kisi();
                    Console.Write("Adı: ");
                    kisi.Adi = Console.ReadLine();
                    Console.Write("Soyadı: ");
                    kisi.Soyad = Console.ReadLine();
                    Console.Write("Telefon No: ");
                    kisi.TelNo = Console.ReadLine();
                    
                    var sonuc = islem.Guncelle(kisi);

                    if (sonuc == 1)
                    {
                        Console.WriteLine("Kayıt başarıyla güncellendi.");
                    }
                    else
                    {
                        Console.WriteLine("Güncellenecek kayıt bulunamadı !!!");
                    }                    
                }
                else if (secim == 4)
                {                    
                    var sonuc = islem.Listele();

                    if (sonuc == null)
                    {
                        Console.WriteLine("Rehberde kayıt bulunamadı !!!");
                    }
                    else
                    {
                        foreach (var item in sonuc)
                        {
                            Console.WriteLine("Adı: {0}\nSoyadı: {1}\nTelefon No: {2}", item.Adi, item.Soyad, item.TelNo);
                            Console.WriteLine("\t**********");
                        }
                    }                    
                }
                else if (secim == 5)
                {                   
                    Kisi kisi = new Kisi();

                    Console.Write("Aranacak kişinin adı: ");
                    kisi.Adi = Console.ReadLine();
                    Console.Write("Aranacak kişisinin soyadı: ");
                    kisi.Soyad = Console.ReadLine();

                    var sonuc = islem.Ara(kisi);

                    if (sonuc == null)
                    {
                        Console.WriteLine("Kayıt bulunamadı !!!");
                    }
                    else
                    {
                        Console.WriteLine("Adı: {0}\nSoyadı: {1}\nTelefon No: {2}", sonuc.Adi, sonuc.Soyad, sonuc.TelNo);
                    }                    
                }

            }
        }
    }
}
