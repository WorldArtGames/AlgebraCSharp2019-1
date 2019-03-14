using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite riječ : ");
            string text = Console.ReadLine();
            int len = text.Length;
            bool flag = true;

            //provjera palindroma
            for (int i = 0; i < len / 2; i++)
            {
                if (text[i] != text[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }

            //test palindroma
            if (flag)
            {
                Console.WriteLine("{0} je palindrom", text);
            }
            else
            {
                Console.WriteLine("{0} nije palindrom", text);
            }
            Console.ReadLine();
        }
    }
}
