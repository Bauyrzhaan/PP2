using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/User/Desktop/PP2/week2/Task4";
            DirectoryInfo directory = new DirectoryInfo(path);
            String path2 = directory.Parent.FullName;
            FileStream fs = File.Create(path2 + "/Bauka.txt");
            fs.Close();
            File.Copy(path + "/Bauka.txt", path2 + "/Bauka.txt");
            File.Delete(path + "/Bauka.txt");
        }
    }
}
