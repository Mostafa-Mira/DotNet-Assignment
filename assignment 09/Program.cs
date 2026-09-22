using System.Drawing;
using System.Reflection;

namespace assignment_09
{
    internal class Program
    {
        #region problem 01
        /*
        enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        
       }
        */
        #endregion

        #region problem 03
        /*
        enum Grades : short
        {
            F = 1,
            D,
            C,
            B,
            A
        }
        */
        #endregion

        #region problem 05
        /*
        class Person
        {
            public string Name { get; set; }
            public string Department { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Department}";
            }
        }
        */
        #endregion

        #region problem 07
        /*
        class Parent
        {
            public virtual int Salary { get; set; }
        }

        class Child : Parent
        {
            public sealed override int Salary
            {
                get { return base.Salary; }
                set { base.Salary = value; }
            }

            public void DisplaySalary()
            {
                Console.WriteLine(Salary);
            }
        }
        */
        #endregion

        #region problem 09
        /*
        static class Utility
        {
            public static double CalculatePerimeter(double length, double width)
            {
                return 2 * (length + width);
            }
        }
        */
        #endregion

        #region problem 11
        /*
        class ComplexNumber
        {
            public int Real { get; set; }
            public int Imag { get; set; }

            public override string ToString()
            {
                return $"{Real} + {Imag}i";
            }

            public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
            {
                return new ComplexNumber()
                {
                    Real = (Left.Real * Right.Real) - (Left.Imag * Right.Imag),
                    Imag = (Left.Real * Right.Imag) + (Left.Imag * Right.Real)
                };
            }
        }
        */
        #endregion

        #region problem 13
        /*
        enum Gender : byte
        {
            Male,
            Female
        }
        */
        #endregion

        #region problem 15
        /*
        static class Utility
        {
            public static double CelsiusToFahrenheit(double Celsius)
            {
                return (Celsius * 9 / 5) + 32;
            }

            public static double FahrenheitToCelsius(double Fahrenheit)
            {
                return (Fahrenheit - 32) * 5 / 9;
            }
        }
        */
        #endregion

        #region problem 17
        /*
        enum Grades
        {
            F = 1,
            D,
            C,
            B,
            A
        }
        */
        #endregion

        #region problem 19
        /*
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                Employee Employee = (Employee)obj;

                return Id == Employee.Id && Name == Employee.Name;
            }
        }


        class Helper2<T>
        {
            public static int SearchArray(T[] Arr, T Value)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }

                return -1;
            }
        }
        */
        #endregion

        #region problem 22
        /*
        class Helper
        {
            public static T Max<T>(T X, T Y) where T : IComparable<T>
            {
                if (X.CompareTo(Y) > 0)
                    return X;

                return Y;
            }
        }
        */
        #endregion

        #region problem 24
        /*
        class Helper2<T>
        {
            public static void ReplaceArray(T[] Arr, T OldValue, T NewValue)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(OldValue))
                        Arr[i] = NewValue;
                }
            }
        }
        */
        #endregion

        #region problem 26
        /*
        struct Rectangle
        {
            public int Length { get; set; }
            public int Width { get; set; }
        }


        static void Swap(ref Rectangle X, ref Rectangle Y)
        {
            Rectangle Temp = X;
            X = Y;
            Y = Temp;
        }
        */
        #endregion

        #region problem 28
        /*
        class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                Department Department = (Department)obj;

                return Id == Department.Id;
            }
        }


        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Department Department { get; set; }

            public override bool Equals(object obj)
            {
                Employee Employee = (Employee)obj;

                return Id == Employee.Id;
            }
        }


        class Helper2<T>
        {
            public static int SearchArray(T[] Arr, T Value)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }

                return -1;
            }
        }
        */
        #endregion

        #region problem 30
        /*
        struct Circle
        {
            public double Radius { get; set; }
            public string Color { get; set; }

            public override bool Equals(object obj)
            {
                Circle C = (Circle)obj;

                return Radius == C.Radius && Color == C.Color;
            }

            public static bool operator ==(Circle Left, Circle Right)
            {
                return Left.Equals(Right);
            }

            public static bool operator !=(Circle Left, Circle Right)
            {
                return !Left.Equals(Right);
            }
        }


        class CircleClass
        {
            public double Radius { get; set; }
            public string Color { get; set; }

            public override bool Equals(object obj)
            {
                CircleClass C = (CircleClass)obj;

                return Radius == C.Radius && Color == C.Color;
            }
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region problem 01
            /*
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }
            */
            #endregion

            #region problem 02
            // It is recommended to explicitly assign values to make the enum values clear and avoid unexpected changes if new members are added
            #endregion

            #region problem 03
            /*
            foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"{grade} = {(short)grade}");
            }
            */
            #endregion

            #region problem 04
            // It gives a compile-time error because the value is outside the underlying type's range
            #endregion

            #region problem 05
            /*
            Person P01 = new Person();
            P01.Name = "Ali";
            P01.Department = "IT";

            Person P02 = new Person();
            P02.Name = "Ahmed";
            P02.Department = "HR";

            Console.WriteLine(P01);
            Console.WriteLine(P02);
            */
            #endregion

            #region problem 06
            // It allows a derived class to override the property and provide its own implementation
            #endregion

            #region problem 07
            /*
            Child C01 = new Child();

            C01.Salary = 5000;

            C01.DisplaySalary();
            */
            #endregion

            #region problem 08
            // Because sealed prevents further overriding in derived classes
            #endregion

            #region problem 09
            /*
            Console.WriteLine(Utility.CalculatePerimeter(5, 3));
            */
            #endregion

            #region problem 10
            // Static members belong to the class, while object members belong to an object
            #endregion

            #region problem 11
            /*
            ComplexNumber C1 = new ComplexNumber() { Real = 2, Imag = 3 };
            ComplexNumber C2 = new ComplexNumber() { Real = 4, Imag = 5 };

            ComplexNumber C3 = C1 * C2;

            Console.WriteLine(C3);
            */
            #endregion

            #region problem 12
            // No, you cannot overload all operators in C#. Some operators, such as &&, ||, ?:, ., and new, cannot be overloaded because C# does not allow user-defined implementations for them
            #endregion

            #region problem 13
            /*
            Console.WriteLine($"Default int enum size: {sizeof(int)} bytes");
            Console.WriteLine($"Gender enum size: {sizeof(Gender)} bytes");
            */
            #endregion

            #region problem 14
            // You should consider changing the underlying type of an enum when you want to reduce memory usage, especially when the enum has a large number of values or many enum variables are stored
            #endregion

            #region problem 15
            /*
            double C = Utility.CelsiusToFahrenheit(25);
            double F = Utility.FahrenheitToCelsius(77);

            Console.WriteLine(C);
            Console.WriteLine(F);
            */
            #endregion

            #region problem 16
            // Because a static class cannot be instantiated, so it does not need an instance constructor
            #endregion

            #region problem 17
            /*
            string Input = Console.ReadLine();

            if (Enum.TryParse(Input, out Grades Grade))
            {
                Console.WriteLine(Grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }
            */
            #endregion

            #region problem 18
            // Enum.TryParse is safer because it returns false when the input is invalid instead of throwing an exception, and it directly converts the value to the enum type
            #endregion

            #region problem 19
            /*
            Employee[] Employees =
            {
                new Employee() { Id = 1, Name = "Ali" },
                new Employee() { Id = 2, Name = "Ahmed" },
                new Employee() { Id = 3, Name = "Mostafa" }
            };

            Employee SearchEmployee = new Employee() { Id = 2, Name = "Ahmed" };

            int Index = Helper2<Employee>.SearchArray(Employees, SearchEmployee);

            Console.WriteLine(Index);
            */
            #endregion

            #region problem 20
            /*
             Equals is used to compare the values/data of objects, while == normally compares references for classes and may need to be overloaded for custom value comparison

              For a struct, Equals compares the values by default, while == must be overloaded if you want to compare the values using ==

             */
            #endregion

            #region problem 21
            // Overriding ToString() allows you to control how an object is represented as a string, making it easier to display its data in a readable format
            #endregion

            #region problem 22
            /*
            Console.WriteLine(Helper.Max(10, 20));
            Console.WriteLine(Helper.Max(10.5, 5.5));
            Console.WriteLine(Helper.Max("Ahmed", "Mostafa"));
            */
            #endregion

            #region problem 23
            /*
             Yes, generics can be constrained to specific types using the where keyword

            For example:
            class Helper<T> where T : class
            {
            }
            */
            #endregion

            #region problem 24
            /*
            int[] Numbers = { 1, 2, 1, 3, 1 };

            Helper2<int>.ReplaceArray(Numbers, 1, 5);

            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }

            string[] Names = { "Ali", "Ahmed", "Ali", "Mostafa" };

            Helper2<string>.ReplaceArray(Names, "Ali", "Omar");

            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
            */
            #endregion

            #region problem 25
            /*
             Generic Method: The type parameter is defined for a specific method and can be different each time the method is called
             Generic Class: The type parameter is defined for the whole class and is used by its methods and members
             */
            #endregion

            #region problem 26
            /*
            Rectangle R1 = new Rectangle() { Length = 10, Width = 5 };
            Rectangle R2 = new Rectangle() { Length = 20, Width = 15 };

            Swap(ref R1, ref R2);

            Console.WriteLine($"{R1.Length}, {R1.Width}");
            Console.WriteLine($"{R2.Length}, {R2.Width}");
            */
            #endregion

            #region problem 27
            // Because a generic Swap method can work with different types using the same code, which reduces code duplication and makes the program easier to maintain
            #endregion

            #region problem 28
            /*
            Department IT = new Department() { Id = 1, Name = "IT" };
            Department HR = new Department() { Id = 2, Name = "HR" };

            Employee[] Employees =
            {
                new Employee() { Id = 1, Name = "Ali", Department = IT },
                new Employee() { Id = 2, Name = "Ahmed", Department = HR },
                new Employee() { Id = 3, Name = "Mostafa", Department = IT }
            };

            Employee SearchEmployee = new Employee() { Id = 3 };

            int Index = Helper2<Employee>.SearchArray(Employees, SearchEmployee);

            Console.WriteLine(Index);
            */
            #endregion

            #region problem 29
            // Overriding Equal allows the program to compare departments based on their values, such as Id, instead of comparing object references. This makes searches more accurate
            #endregion

            #region problem 30
            /*
            Circle C1 = new Circle() { Radius = 5, Color = "Red" };
            Circle C2 = new Circle() { Radius = 5, Color = "Red" };

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));

            CircleClass C3 = new CircleClass() { Radius = 5, Color = "Red" };
            CircleClass C4 = new CircleClass() { Radius = 5, Color = "Red" };

            Console.WriteLine(C3 == C4);
            Console.WriteLine(C3.Equals(C4));
            */
            #endregion

            #region problem 31 
            // Because C# does not know how to compare the fields of a custom struct using ==. You must overload == to define how the comparison should work
            #endregion 

        }
    }
}
