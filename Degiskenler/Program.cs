using System;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; //1 Byte
            sbyte sb = 5; //1 Byte

            short s = 5; //2 Byte
            ushort us = 5; //2 Byte

            Int16 i16 = 2; // 2 Byte
            int i = 2; // 4 Byte
            Int32 i32 = 3; // 4 Byte
            Int64 i64 = 4; //8 Byte

            uint ui = 2; // 4 Byte 
            long l = 3; // 8 Byte

            ulong ul = 4; // 8 Byte

            float f = 5; // 4 Byte
            double d = 5; // 8 Byte
            decimal de = 5; // 16 Byte

            char c = '5'; //2 Byte

            string str = "Onur"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(DateTime.Now.ToShortDateString());

        }
    }
}
