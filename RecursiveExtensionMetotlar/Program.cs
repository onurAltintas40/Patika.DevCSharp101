using System;

namespace RecursiveExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }


            Console.WriteLine(result.ToString());

            Islemler ornek = new();

            Console.WriteLine(ornek.Expo(3, 4));

            //Extension Metotlar

            string ifade = "Onur Altıntaş";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.MakeUpperCase());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] dizi = { 9, 6, 3, 7, 8, 5, 2, 0 };

            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEven());
            string deneme = "Onur";
            Console.WriteLine(deneme.GetFirstChacracter());


        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);

        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChacracter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
