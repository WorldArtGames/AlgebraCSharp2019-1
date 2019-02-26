using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3._1._3.knjiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablica množenja");
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", (i * j).ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        

    }
}
