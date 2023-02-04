using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int c = 0;
            if (s.Length % 2 == 0)
            {
                string a = s.Substring(0,s.Length/2);
                string b = s.Substring(s.Length / 2, s.Length / 2);
                s = "";
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        c++;
                        s += a[i] + b[i];
                    }
                }
                if (c == 2)
                {
                    s = String.Concat(s.OrderBy(l => l));
                    if (s[0] == s[1] && s[2] == s[3])
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
            else
            {
                Console.WriteLine("NO");
                Console.ReadKey();
            }
        }
    }
}
