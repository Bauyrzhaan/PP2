using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{  
    class Student
    {
        
        public string name; 
        public string id;
        public int year;
        public Student()
        {
            name = Console.ReadLine();  // input the information about student
            id = Console.ReadLine();
            year =int.Parse(Console.ReadLine());
        }
        public Student(string name, string id, int year) // constructor
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public string getId()
        {

            return this.ID;
        }
        public Student(string n, string i) // we don't use this constructor only for given task
        {
            name = n;
            id = i;
        }
        public void info() // write the information and add the year
        {
            Console.WriteLine(name + " " + id + " " + (year + 1));
        }
    }

    
    class Program{
                         
        static void Main(string[] args)
        {
             Student a = new Student();
            a.info(); 
            Student b = new Student("Bauyrzhan", "18bd", 2018);
            b.info();
        }
    }
}
