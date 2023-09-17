using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifOrnek
{
    internal class car: CarInfo
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        private int year;
        private string marka;
        public int YIL
        {
            get { return year; }
            set { year = Math.Abs(value); }
        }
        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

    }
}
