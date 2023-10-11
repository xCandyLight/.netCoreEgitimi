using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationVeProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ceren";
            ogrenci.Soyad = "AK";
            ogrenci.OgrenciNo = 4198;
            ogrenci.Sinif = 12;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Taha Emre", "KAYFECİ", 4269, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("------ Öğrenci Bilgileri ------");
            Console.WriteLine("Öğrenci Adı    :{0}", this.Ad);
            Console.WriteLine("Öğrenci Soyadı :{0}", this.Soyad);
            Console.WriteLine("Öğrenci No     :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf  :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
