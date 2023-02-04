using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            int s = 0;
            int p = n;

            List<List<int>> tree = new List<List<int>>();
            for (int i = 0; i < n - 1; i++)
            {
                tree.Add(new List<int>()); //Добавть строку
            }
            for (int i = 0; i < n - 1; i++)
            {
                arr = Console.ReadLine().Split(' ');
                tree[int.Parse(arr[0]) - 1].Add(int.Parse(arr[1]));//Добавить элемент в строку
            }
            arr = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(arr, l => int.Parse(l));
            List<int> ans = new List<int>();



            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < tree[i].Count(); j++)
                {
                    if (ar[i] != ar[tree[i][j] - 1]) 
                    {
                        s++;
                        p = j;
                    }
                }
                if (s > 1)
                {
                    ans.Add(i+1);
                }
                if (s == 1 && ans.IndexOf(i+1) == -1)
                {
                    ans.Add(tree[i][p]);
                }
                s = 0;
            }
            if (ans.Count() > 1)
            {
                Console.WriteLine("NO");
                Console.ReadKey();
            }
            else
            {
                if(ans.Count() == 1)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(ans[0]);
                    Console.ReadKey();
                }
                if (ans.Count() == 0)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(n);
                    Console.ReadKey();
                }
            }
        }
    }
}
