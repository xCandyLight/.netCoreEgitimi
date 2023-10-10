using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Sorunun Çözümü
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Girmek istediğiniz Sayı Adetini Giriniz: ");

            int sayiAdeti = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[sayiAdeti];
            for (int i = 0; i < sayiAdeti; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayısı Giriniz: ", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girmiş Olduğunuz Çift Sayılar: ");
            int boluneBilenSayi = 0;
            for (int i = 0; i < sayiAdeti; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    boluneBilenSayi++;
                    Console.WriteLine(sayiDizisi[i] + " ");
                }
            }

            // 2. Sorunun Çözümü
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Hangi Sayının Bölünmesini İstersiniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç Adet Sayı Girmek İstersiniz: ");
            int sayiAdeti2 = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi2 = new int[sayiAdeti2];
            for (int i = 0; i < sayiAdeti2; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayısı Giriniz: ", i + 1);
                sayiDizisi2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girmiş Olduğunuz Çift Sayılar: ");
            int boluneBilenSayi2 = 0;
            for (int i = 0; i < sayiAdeti2; i++)
            {
                if (sayiDizisi2[i] % m == 0 || sayiDizisi2[i] == m)
                {
                    boluneBilenSayi2++;
                    Console.WriteLine(sayiDizisi2[i] + " ");
                }
            }

            // 3. Sorunun Çözümü
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Kaç Adet Kelime Girmek İstersiniz: ");
            int sayiAdeti3 = Convert.ToInt32(Console.ReadLine());
            string[] sayiDizisi3 = new string[sayiAdeti3];
            for (int i = 0; i < sayiAdeti3; i++)
            {
                Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
                sayiDizisi3[i] = (Console.ReadLine());
            }

            Array.Reverse(sayiDizisi3);
            Console.WriteLine("Girmiş Olduğunuz Kelimeler: ");
            for (int i = 0; i < sayiAdeti3; i++)
            {
                Console.WriteLine(sayiDizisi3[i] + " ");

            }

            // 4. Sorunun Çözümü
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir Cümle Yazınız: ");
            string sayiDizisi4 = Console.ReadLine();

            int harf = sayiDizisi4.Length;
            string[] bosluk = sayiDizisi4.Split(' ');
            int noSpaces = harf - (bosluk.Length - 1);
            Console.WriteLine("Toplam Kelime: " + bosluk.Length + " Toplam Harf: " + noSpaces);

            Console.ReadKey();   
        }
    }
}

