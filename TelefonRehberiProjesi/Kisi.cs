

using System;
using System.Collections.Generic;

namespace TelefonRehberiProjesi
{
    public class Kisi
    {
        private string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        private string telNo;

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public static implicit operator Kisi(List<Kisi> v)
        {
            throw new NotImplementedException();
        }
    }
}
