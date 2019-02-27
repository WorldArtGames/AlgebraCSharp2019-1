using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4.Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cijeli pozitivni broj: ");
            // 5! = (5*4*3*2*1 =120)
            try
            {
                int a = int.Parse(Console.ReadLine());
                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    // Console.WriteLine(i);
                    fact *= i;
                }
                Console.WriteLine(fact)
            }

            ;
            
        }
        catch (Exception ex)    }

}
