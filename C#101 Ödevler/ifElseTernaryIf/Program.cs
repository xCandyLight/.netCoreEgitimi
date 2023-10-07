using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseTernaryIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time <= 18)
            {
                Console.WriteLine("Tünaydın !");
            }
            else
            {
                Console.WriteLine("İyi geceler!");
            }

            string sonuc = time <= 18 ? "Tünaydın!" : "İyi Geceler!";
            sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "Tünaydın!" : "İyi Geceler!";
            Console.WriteLine(sonuc);

            Console.ReadKey();
        }
    }
}
