using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite jedan cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0 || a % 3 == 0)
            {
                Console.WriteLine("Broj je dobar.");
            }
            else
            {
                Console.WriteLine("Broj NIJE dobar!");
            }
            Console.ReadKey();
        }
       
    }
}
