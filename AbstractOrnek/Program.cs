using System;

namespace AbstractOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();

            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRenkNe().ToString());
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRenkNe().ToString());
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRenkNe().ToString());
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        }
    }
}
