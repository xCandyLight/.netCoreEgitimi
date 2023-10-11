using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace instanceFieldProperty
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

            Calisan calisan = new Calisan();
            calisan.Ad = "Ceren";
            calisan.Soyad = "AK";
            calisan.No = 4198;
            calisan.Departman = "IT";
            calisan.CalisanBilgileri();
            Console.WriteLine("-----------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Taha Emre";
            calisan2.Soyad = "Kayfeci";
            calisan2.No = 4269;
            calisan2.Departman = "IT";
            calisan2.CalisanBilgileri();

            Console.ReadKey();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
