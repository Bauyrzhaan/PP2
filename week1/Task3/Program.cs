using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n * 2;
            int[] a = new int[n];
            int[] b = new int[m];
            string [] arr = Console.ReadLine().Split();
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            for(int i = 0; i < n; i++)
            {
                b[2*i] = a[i];
                b[2 * i + 1] = a[i + 1];
            }
            for(int i = 0; i < m; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}
