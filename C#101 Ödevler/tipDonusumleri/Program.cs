using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Bilinçsiz Dönüşüm ------");
            //Implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);
            long h = d;
            Console.WriteLine("h: " + h);
            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Ceren";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            Console.WriteLine("------ Bilinçli Dönüşüm ------");
            //Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            Console.WriteLine("------ ToString Metodu ------");
            //ToString Metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            Console.WriteLine("------ System.Convert Sınıfı ------");
            //System.Convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            Console.WriteLine("------ Parse Metodu ------");
            //Parse

            ParseMethod();


            Console.ReadLine();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int sayi;
            double dSayi;

            sayi = Int32.Parse(metin1);
            dSayi = Double.Parse(metin2);

            Console.WriteLine("Sayı: " + sayi);
            Console.WriteLine("Double Sayı: " + dSayi);
        }
    }
}
