using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class islem
    {
        public int topla(int sayi1, int sayi2) 
        {  
         int sayi3=sayi1+sayi2;
            Console.WriteLine("S3 den gelen değer "+sayi3);
            return sayi3;
        }
        public int kare (int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç : "+sonuc);
            return sonuc;
        }
    }
}
