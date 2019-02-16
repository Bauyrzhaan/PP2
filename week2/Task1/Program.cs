using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{

    class Program
    {
        public static bool F1(string s,int k) // проверяем является ли слово строка палиндромом
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                
                if (s[i] != s[k-i-1]) return false;
            }
            return true;
        }
       
        
        static void Main(string[] args)
        {   
            StreamReader sr= new StreamReader(@"C:/Users/User/Desktop/PP2/week2/Task2/input.txt"); // вводим данные через инпут файл
            string s= sr.ReadToEnd();
            
            int k = s.Count();
            if (F1(s,k) == true) Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            sr.Close();
            Console.ReadKey();
        }
    }
}
