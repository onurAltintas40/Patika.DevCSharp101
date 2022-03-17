

namespace AbstractOrnek
{
    public class Civic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public override Renk StandartRenkNe()
        {
            return Renk.Gri;
        }
    }
}
