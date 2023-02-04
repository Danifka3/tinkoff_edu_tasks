using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ar = new string[n];
            ar = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(ar, l => int.Parse(l));
            int k = int.Parse(Console.ReadLine());
            int s = 1;
            int b = 0;

            for (int i = 0; i < n; i++)
            {
                if (s >= k)
                {
                    b++;
                }
                for (int j = i+1; j < n; j++)
                { 
                    if (arr[i] != arr[j])
                    {
                        s++;
                        if (s >= k)
                        {
                            b++;
                        }
                    }                   
                }
                s = 1;
            }
            Console.WriteLine(b);
        }
    }
}
