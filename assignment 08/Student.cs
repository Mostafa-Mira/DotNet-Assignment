using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal class Student
    {
        public int Id;
        public string Name;
        public double Grade;

        public Student()
        {
        }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Grade = Copy.Grade;
        }
    }
}
