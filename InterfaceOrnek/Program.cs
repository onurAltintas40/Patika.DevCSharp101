using System;

namespace InterfaceOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.StandartRengiNedir().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.StandartRengiNedir().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.StandartRengiNedir().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
        }
    }
}
