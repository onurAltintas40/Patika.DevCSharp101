using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Atama ve İşlem Operatörleri ***");
            // Atama ve işlem operatörleri

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            y *= 2;
            Console.WriteLine(y);

            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isComplated = false;

            if(isSuccess && isComplated)
                Console.WriteLine("Perfect");

            if(isSuccess || isComplated)
                Console.WriteLine("Great");
            if(isSuccess && !isComplated)
                Console.WriteLine("Fine");


            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            Console.WriteLine("*** İlişkisel Operatörler ***");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik Operatörler ***");
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);



        }
    }
}
