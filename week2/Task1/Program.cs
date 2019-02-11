using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {
        public static bool F1(string input,int k)
        {
            for (int i = 0; i < input.Length/2; i++)
            {
                
                if (input[i] != input[k-i-1]) return false;
            }
            return true;
        }
       
        
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"C: \Users\User\Desktop\input.txt");
            int k = input.Length;
            if (F1(input,k) == true) Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


        }
    }
}
