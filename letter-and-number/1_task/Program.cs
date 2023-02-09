using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_and_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length == 2)
            {
                if ((Char.IsLetter(s[0]) == true && Char.IsLetter(s[1]) == false) || (Char.IsLetter(s[1]) == true && Char.IsLetter(s[0]) == false))
                {
                    Console.WriteLine("YES");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("NO");
                Console.ReadKey();
            }
        }
    }
}