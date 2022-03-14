using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dikdortgen dikdortgen = new Dikdortgen();

            //dikdortgen.KisaKenar = 10;
            //dikdortgen.UzunKenar = 20;

            Console.WriteLine("Class Alan Hesapla: {0}", dikdortgen.AlanHesapla());


            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar = 10;
            dikdortgen_Struct.UzunKenar = 20;

            Console.WriteLine("Struct Alan Hesapla: {0}", dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public int KisaKenar;

        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;

        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
