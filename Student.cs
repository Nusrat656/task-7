using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Student
    {
        public string Surname;
        public string name;

        public Student(string surname, string name)
        {
            Surname = surname;
            this.name = name;
        }

        public void FullInfo()
        {
            Student student=new Student(name, name);
            Console.WriteLine($"Surname: {Surname}\nName: {this.name}\nAge:");
        }
    }
}
