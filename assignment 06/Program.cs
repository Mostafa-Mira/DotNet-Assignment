using System;
using System.Drawing;
using System.Reflection;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_06
{

    #region problem 01 
    /*
    internal struct Point
    {
        public int x;
        public int y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    */
    #endregion

    #region problem 03
    /*
    class TypeA
    {
        private int F;
        internal int G;
        public int H;
    }
    */
    #endregion

    #region problem 05
    /*
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private decimal Salary;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public decimal SalaryValue
        {
            get { return Salary; }
            set { Salary = value; }
        }
    }
    */
    #endregion

    #region problem 07 
    /*
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int _x)
        {
            x = _x;
            y = 0;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    */
    #endregion

    #region problem 09
    /*
    internal struct Point
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    */
    #endregion

    #region problem 11
    /*
    struct Point
    {
        public int x;
        public int y;
    }

    class Employee
    {
        public int id;
        public string name;
    }
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 01
            /*
            Point p1 = new Point();
            Point p2 = new Point(5, 8);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            */
            #endregion

            #region problem 02
            // A struct is a value type in C#, and it does not support inheritance from another struct or class
            #endregion

            #region problem 03
            /*
            TypeA t = new TypeA();

            t.G = 10;
            t.H = 20;
            */
            #endregion

            #region problem 04
            // Access modifiers control where a class member can be accessed
            #endregion

            #region problem 05
            /*
            Employee E01 = new Employee();

            E01.Id = 1;
            E01.SetName("Ali");
            E01.SalaryValue = 5000;

            Console.WriteLine(E01.GetName());
            Console.WriteLine(E01.Id);
            Console.WriteLine(E01.SalaryValue);
            */
            #endregion

            #region problem 06
            // Encapsulation protects data and controls how it is accessed
            #endregion

            #region problem 07
            /*
            Point p1 = new Point(5);
            Point p2 = new Point(5, 8);

            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);

            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            */
            #endregion

            #region problem 08
            // Constructors in structs are special methods used to initialize the struct fields
            #endregion

            #region problem 09
            /*
            Point p1 = new Point(5, 8);
            Point p2 = new Point(10, 20);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            */
            #endregion

            #region problem 10 
            // Overriding ToString() makes objects easier to read by showing their data in a clear and useful format
            #endregion

            #region problem 11
            /*
            Point p = new Point();
            p.x = 10;
            p.y = 20;

            Employee e = new Employee();
            e.id = 1;
            e.name = "Ali";

            ChangePoint(p);
            ChangeEmployee(e);

            Console.WriteLine(p.x);
            Console.WriteLine(e.name);
            */
            #endregion

            #region problem 12
            // Structs are value types, so their data is stored directly with the variable. Classes are reference types, so the object is stored on the heap and the variable holds a reference to it
            #endregion

            #region problem 01 part 02
            // A copy constructor is a constructor used to create a new object by copying the values of another object
            #endregion

            #region problem 02 part 02
            /*
            An Indexer allows an object to be accessed like an array using []
            It is used when accessing data by an index or key
            Business cases: Shopping cart to access products, student management system to access students by ID, and inventory system to access products by code
            */
            #endregion

            #region problem 03 part 02

            /*
            Keywords learned: **Struct, Class, Constructor, Constructor Overloading, Encapsulation, Access Modifiers, Properties, Getters, Setters,
            Inheritance, Override, ToString(), Value Type, Reference Type, Copy Constructor, and Indexer
            */
            #endregion
        }
        #region problem 11 (function)
        /*
        static void ChangePoint(Point p)
        {
            p.x = 100;
        }

        static void ChangeEmployee(Employee e)
        {
            e.name = "Ahmed";
        }
        */
        #endregion 
    }
}
