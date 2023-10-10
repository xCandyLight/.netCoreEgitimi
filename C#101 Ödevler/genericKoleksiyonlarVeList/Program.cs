using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace genericKoleksiyonlarVeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            // Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi temizleme
            hayvanListesi.Clear();

            // List içerisinde nesne tutmak 
            List<Kullanicilar> kullanıcıListesi = new List<Kullanicilar>();

            Kullanicilar kullanıcı1 = new Kullanicilar();
            kullanıcı1.Ad = "Ceren";
            kullanıcı1.Soyad = "AK";
            kullanıcı1.Yas = 17;

            Kullanicilar kullanıcı2 = new Kullanicilar();
            kullanıcı2.Ad = "Taha Emre";
            kullanıcı2.Soyad = "Kayfeci";
            kullanıcı2.Yas = 17;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Ad="Çınar",
                Soyad="AK",
                Yas=11
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Ad);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyad);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yas);
            }

            yeniListe.Clear();

            Console.ReadKey();
        }

        public class Kullanicilar
        {
            string ad;
            string soyad;
            int yas;

            public string Ad
            {
                get => ad; set => ad = value;
            }

            public string Soyad
            {
                get => soyad; set => soyad = value; 
            }

            public int Yas
            {
                get => yas; set => yas = value; 
            }


        }
    }
}
