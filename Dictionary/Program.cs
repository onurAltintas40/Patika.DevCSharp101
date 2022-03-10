using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new();

            kullanicilar.Add(10, "Onur Altıntaş");
            kullanicilar.Add(12, "Ahmet Keke");
            kullanicilar.Add(18, "Deniz Ardı");
            kullanicilar.Add(20, "Özcan Çoşar");
          

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Onur Altıntaş"));

            //Remove
            Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(12);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key);
            }

            //Values
            Console.WriteLine("*** Values ***");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
