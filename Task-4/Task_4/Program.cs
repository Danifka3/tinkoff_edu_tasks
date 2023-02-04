using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ar = new string[n];
            ar = Console.ReadLine().Split(' ');
            List<long> arr = new List<long>(n);
            for (int i = 0; i < n; i++)
            {
                arr.Add(long.Parse(ar[i])); //Добавть строку
            }
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++) 
            {
                ar = Console.ReadLine().Split(' ');
                if (int.Parse(ar[0]) == 0)
                {
                    if (arr.Contains(int.Parse(ar[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                if (int.Parse(ar[0]) == 1)
                {
                    long x = long.Parse(ar[1]);
                    for (int j = 0; j < arr.Count(); j++)
                    {
                        arr[j] += x;
                    }
                }
                if (int.Parse(ar[0]) == 2)
                {
                    arr.Add(long.Parse(ar[1]));
                }
                if (int.Parse(ar[0]) == 3)
                {
                    arr.Remove(long.Parse(ar[1]));
                }
            }
        }
    }
}
