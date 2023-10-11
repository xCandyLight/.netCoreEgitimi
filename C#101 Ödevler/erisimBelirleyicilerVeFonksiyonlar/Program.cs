using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisimBelirleyicilerVeFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizini
            /*
               class SiniAdi
               {
                   [Erişim belirleyici] [Veri tipi] OzellikAdi;
                   [Erişim belirleyici] [Geri dönüş tipi] MetotAdi ([Parametre Listesi])
                   {
                     // Metot komutları
                   }
               }
            */

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan = new Calisan("Ceren", "AK", 4198, "IT");
            calisan.CalisanBilgileri();
            Console.WriteLine("-----------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Taha Emre";
            calisan2.Soyad = "Kayfeci";
            calisan2.No = 4269;
            calisan2.Departman = "IT";
            calisan2.CalisanBilgileri();

            Console.WriteLine("------ Çalışan 3 ------");
            Calisan calisan3 = new Calisan("Çınar", "AK");
            calisan3.CalisanBilgileri();


            Console.ReadKey();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }   

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
