﻿

namespace InterfaceOrnek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNedir()
        {
            return Renk.Beyaz;
        }
    }
}
