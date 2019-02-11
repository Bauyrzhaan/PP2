using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool F1(int k)
        {
            if (k <= 1) return false;
            for (int i = 2; i < k; i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int sum = 0;
            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);

            }
            for (int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true) sum++;

            }
            Console.WriteLine(sum);
            for (int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true) Console.Write(a[i] + " ");

            }
        }
    }
}
