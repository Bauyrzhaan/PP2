using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class FarManager
    { 
        public int cursor;
        public int size;
        public string path;
        DirectoryInfo DOP = null;
        FileSystemInfo COP=null;
        public FarManager()
        {
            cursor=0;
        }
        public FarManager(string path)
        {
            this.path = path;
            cursor=0;
            DOP = new DirectoryInfo(path);
            size=DOP.GetFileSystemInfos().Length;
        }
        public void UP()
            {
            cursor--;
            if(cursor<0) cursor=size-1;
            }
        public void DOWN()
            {
            cursor++;
            if(cursor==size) cursor=0;
            }
        public void COLOUR(FileSystemInfo fs,int index)
            {
               if(cursor==index)
               {
                Console.ForegroundColor=ConsoleColor.Red;
                COP=fs;
               }
               else if(fs.GetType()==typeof(FileInfo))
                {
                Console.ForegroundColor=ConsoleColor.Yellow;
                }     
               else 
                {
                Console.ForegroundColor=ConsoleColor.Blue;
                }
            }
        public void ENTER()
        {
            DOP = new DirectoryInfo(path);
            FileSystemInfo[] files = DOP.GetFileSystemInfos();
            int k = 0;
            foreach(FileSystemInfo fs in files)
            {   
                COLOUR(fs,k);
                k++;
                Console.Write(k + ". ");
                Console.WriteLine(fs.Name);
            }
        }
        public void Calsz()
        {  DOP =new DirectoryInfo(path);
           FileSystemInfo [] fs =DOP.GetFileSystemInfos();
            size=fs.Length;
        }
        public void FAR()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while(consoleKey.Key!=ConsoleKey.Escape)
            {
                Console.Clear();
                Calsz();
                ENTER();
                consoleKey = Console.ReadKey();
                if(consoleKey.Key==ConsoleKey.UpArrow)
                {
                    UP();
                }
                if(consoleKey.Key==ConsoleKey.DownArrow)
                    {
                    DOWN();
                    }
                if(consoleKey.Key==ConsoleKey.Enter)
                    {
                     if(COP.GetType()==typeof(DirectoryInfo))
                        {
                    cursor=0;
                    path=COP.FullName;
                    
                        }
                     }
                     if(consoleKey.Key== ConsoleKey.Backspace)
                        {
                        cursor=0;
                        path=DOP.Parent.FullName;
                        }
                    }
           
                    
                
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/User/Desktop/PP2";
            FarManager farManager = new FarManager(path);
            farManager.FAR();
        }
    }
}