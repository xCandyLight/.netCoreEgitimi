using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ceren");
            //liste.Add(3);
            //liste.Add(true);
            //liste.Add('C');

            //içerisindeki verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //    Console.WriteLine(item);

            // AddRange
            Console.WriteLine("------ Add Range ------");
            //string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayilar = new List<int>();
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);
            // Sort
            Console.WriteLine("------ Sort ------");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine("------ Binary Search ------");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse
            Console.WriteLine("------ Reverse ------");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Clear
            Console.WriteLine("------ Clear ------");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item) ;

            Console.ReadKey();
        }
    }
}
