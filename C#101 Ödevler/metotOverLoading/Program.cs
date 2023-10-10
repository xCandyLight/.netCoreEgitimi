using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Out Parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int OutSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(OutSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);

            // Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ceren","AK");

            Console.ReadKey();
        }

        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}
