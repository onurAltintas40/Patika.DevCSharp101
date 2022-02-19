using System;

namespace ConsoleProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi Girin: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisminizi Girin: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Merhaba " + isim + " " + soyisim);
        }
    }
}
