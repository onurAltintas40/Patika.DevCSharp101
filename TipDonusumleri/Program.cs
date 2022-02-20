using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)

            Console.WriteLine("*** Implicit Conversion (Bilinçsiz Dönüşüm) ***");

            int a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c ;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Onur";
            char f = 'k';
            object g = e + f + d;

            Console.WriteLine("g: " + g);


            // Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("*** Explicit Conversion (Bilinçli Dönüşüm) ***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            //ToString() Methodu

            Console.WriteLine("*** ToString Methodu) ***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.25f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert Methodu

            Console.WriteLine("*** System.Convert Methodu ***");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            //Parse Methodu

            Console.WriteLine("*** Parse Methodu ***");

            static void ParseMethodu()
            {
                string metin = "10";
                string metin2 = "10.25";
                int rakam1;
                double double1;

                rakam1 = Int32.Parse(metin);
                double1 = Double.Parse(metin2);
                Console.WriteLine("Rakam: " + rakam1);
                Console.WriteLine("Double: " + double1);
            }

            ParseMethodu();

        }
    }
}
