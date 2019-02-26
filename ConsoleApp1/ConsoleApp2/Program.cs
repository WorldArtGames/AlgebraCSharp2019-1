using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Zadatak_5_2_3_Velik_Broj

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 100)
            {
                Console.WriteLine("Broj je velik.");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik.");
            }
            Console.ReadKey();
        }
    }
}
