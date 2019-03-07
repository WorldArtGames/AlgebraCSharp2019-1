using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3.Osoba_Enkapsulacija_Prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            Console.Write("Ime: ");
            osoba.Ime = Console.ReadLine();
            Console.Write("Prezime: ");
            osoba.Prezime = Console.ReadLine();

            Console.Write("Starost: ");
            try
            {
                osoba.Starost = int.Parse(Console.ReadLine());
                Console.WriteLine("Unos je ispravan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
