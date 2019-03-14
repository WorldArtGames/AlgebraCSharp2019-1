using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._6_Palindrom_DZ
{
    class Program
    {   
        static void Main(string[] args)
        {
            // Rješenje br.1

            Console.WriteLine("Unesite tekst");
            string tekst = Console.ReadLine();

            tekst = tekst.Replace(" ", "");

            string obrnuto = "";
            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                obrnuto += tekst[i];
            }
            if (tekst == obrnuto)
            {
                Console.WriteLine("Unešeni tekst je palindrom");
            }
            else
            {
                Console.WriteLine("Tekst nije palindrom");
            }

            // Rješenje br.2
            string s, revs = "";
            Console.WriteLine("Unesite rečenicu");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("Rečenica je PALINDROM", s, revs);
            }
            else
            {
                Console.WriteLine("Rečenica NIJE PALINDROM", s, revs);
            }
            Console.ReadKey();




        }
    }
}
