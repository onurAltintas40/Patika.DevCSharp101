

namespace AbstractOrnek
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRenkNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci();
        
    }
}
