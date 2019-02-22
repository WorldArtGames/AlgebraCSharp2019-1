using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Unesite 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite 2. broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", a + b);
            Console.WriteLine("Razlika: {0}", a - b);
            Console.WriteLine("Pritisnite \"Enter\" za kraj...");
            Console.ReadKey();

        }
       

            


    }
}
