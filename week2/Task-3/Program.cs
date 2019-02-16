using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void Level(int lvl)
        {
            for (int i = 0; i < lvl; i++)
            {
                Console.Write("   ");
            }
        }

        public static void Tree(DirectoryInfo path, int lvl)
        {
            foreach (FileInfo f in path.GetFiles())
            {
                Level(lvl);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo dir in path.GetDirectories())
            {
                Level(lvl);
                Console.WriteLine(dir.Name);
                Tree(dir, lvl + 1);
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@"C:/Users/User/Desktop/PP2");
            Tree(path, 0);
            Console.ReadKey();
        }
    }
}
