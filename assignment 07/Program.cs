using System.Drawing;

namespace assignment_07
{
    internal class Program
    {
        #region problem 01 
        /*
        class Car
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public decimal Price { get; set; }

            public Car()
            {
            }

            public Car(int _Id)
            {
                Id = _Id;
            }

            public Car(int _Id, string _Brand)
            {
                Id = _Id;
                Brand = _Brand;
            }

            public Car(int _Id, string _Brand, decimal _Price)
            {
                Id = _Id;
                Brand = _Brand;
                Price = _Price;
            }
        }
        */
        #endregion

        #region problem 03
        /*
        class Calculator
        {
            public int Sum(int x, int y)
            {
                return x + y;
            }

            public int Sum(int x, int y, int z)
            {
                return x + y + z;
            }

            public double Sum(double x, double y)
            {
                return x + y;
            }
        }
        */
        #endregion

        #region problem 05
        /*
        class Parent
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Parent(int _X, int _Y)
            {
                X = _X;
                Y = _Y;
            }
        }

        class Child : Parent
        {
            public int Z { get; set; }

            public Child(int _X, int _Y, int _Z) : base(_X, _Y)
            {
                Z = _Z;
            }
        }
        */
        #endregion

        #region problem 07
        /*
        class Parent
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Parent(int _X, int _Y)
            {
                X = _X;
                Y = _Y;
            }

            public int Product()
            {
                return X * Y;
            }
        }

        class Child : Parent
        {
            public int Z { get; set; }

            public Child(int _X, int _Y, int _Z) : base(_X, _Y)
            {
                Z = _Z;
            }

            public new int Product()
            {
                return X * Y * Z;
            }
        }
        */
        #endregion

        #region problem 09 
        /*
        class Parent
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Parent(int _X, int _Y)
            {
                X = _X;
                Y = _Y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        class Child : Parent
        {
            public int Z { get; set; }

            public Child(int _X, int _Y, int _Z) : base(_X, _Y)
            {
                Z = _Z;
            }

            public override string ToString()
            {
                return $"({X}, {Y}, {Z})";
            }
        
        }
        */
        #endregion

        #region problem 11
        /*
        interface IShape
        {
            double Area { get; }
            void Draw();
        }

        class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public double Area
            {
                get { return Width * Height; }
            }

            public void Draw()
            {
                Console.WriteLine("Drawing Rectangle");
            }
        }
        */
        #endregion

        #region problem 13
        /*
        interface IShape
        {
            double Area { get; }
            void Draw();

            void PrintDetails()
            {
                Console.WriteLine($"Area = {Area}");
            }
        }

        class Circle : IShape
        {
            public double Radius { get; set; }

            public double Area
            {
                get { return 3.14 * Radius * Radius; }
            }

            public void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }
        */
        #endregion

        #region problem 15
        /*
        interface IMovable
        {
            void Move();
        }

        class Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }
        */
        #endregion

        #region problem 17
        /*
        interface IReadable
        {
            void Read();
        }

        interface IWritable
        {
            void Write();
        }

        class File : IReadable, IWritable
        {
            public void Read()
            {
                Console.WriteLine("Reading File");
            }

            public void Write()
            {
                Console.WriteLine("Writing File");
            }
        }
        */
        #endregion

        #region problem 19
        /*
        abstract class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing Shape");
            }

            public abstract double CalculateArea();
        }

        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public override void Draw()
            {
                Console.WriteLine("Drawing Rectangle");
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Problem 01
            /*
            Car C01 = new Car();
            Car C02 = new Car(1);
            Car C03 = new Car(2, "BMW");
            Car C04 = new Car(3, "Mercedes", 500000);
            */
            #endregion

            #region problem 02
            // Because when you define a constructor yourself, C# assumes you want to control how the object is created, so it doesn’t generate the default constructor automatically
            #endregion

            #region Problem 03
            /*
            Calculator C01 = new Calculator();

            Console.WriteLine(C01.Sum(5, 10));
            Console.WriteLine(C01.Sum(5, 10, 15));
            Console.WriteLine(C01.Sum(5.5, 10.5));
            */
            #endregion

            #region problem 04
            // It lets us use the same method name for similar tasks, which makes the code easier to read and reuse
            #endregion

            #region Problem 05
            /*
            Child C01 = new Child(1, 2, 3);
            */
            #endregion

            #region problem 06
            //It allows the child class to initialize the parent class properties by calling the parent constructor
            #endregion

            #region Problem 07
            /*
            Parent P01 = new Parent(1, 2);
            Child C01 = new Child(1, 2, 3);

            Console.WriteLine(P01.Product());
            Console.WriteLine(C01.Product());

            P01 = C01;
            Console.WriteLine(P01.Product());
            */
            #endregion

            #region problem 08 
            // new hides the parent method, while override replaces the parent method and uses the child version at runtime

            #endregion

            #region Problem 09
            /*
            Parent P01 = new Parent(1, 2);
            Child C01 = new Child(1, 2, 3);

            Console.WriteLine(P01);
            Console.WriteLine(C01);
            */
            #endregion

            #region problem 10
            // To return a useful string that describes the object instead of the default class name
            #endregion

            #region Problem 11
            /*
            Rectangle R01 = new Rectangle();

            R01.Width = 5;
            R01.Height = 10;

            Console.WriteLine(R01.Area);
            R01.Draw();
            */
            #endregion

            #region problem 12
            // Because an interface only defines what a class should do, but it doesn't provide the actual implementation
            #endregion

            #region Problem 13
            /*
            Circle C01 = new Circle();

            C01.Radius = 5;
            C01.PrintDetails();
            */
            #endregion

            #region problem 14
            // They allow adding new methods to an interface without forcing all existing classes to implement them
            #endregion

            #region Problem 15
            /*
            IMovable M01 = new Car();
            M01.Move();
            */
            #endregion

            #region problem 16
            // It allows different classes to be treated in the same way through the interface, making the code more flexible
            #endregion

            #region Problem 17
            /*
            File F01 = new File();

            F01.Read();
            F01.Write();
            */
            #endregion

            #region problem 18
            // C# allows a class to implement multiple interfaces, so it can have behaviors from different interfaces even though it can inherit from only one class
            #endregion

            #region Problem 19
            /*
            Rectangle R01 = new Rectangle();

            R01.Width = 5;
            R01.Height = 10;

            R01.Draw();
            Console.WriteLine(R01.CalculateArea());
            */
            #endregion

            #region problem 20
            // A virtual method has a default implementation that can be overridden, while an abstract method has no implementation and must be implemented by the derived class
            #endregion

            #region problem 01 part 02
            // A class is a reference type, while a struct is a value type. Classes support inheritance, but structs do not
            #endregion

            #region problem 02 part 02
            /*
            Has - A → Aggregation / Composition
            Uses - A → Dependency
            Implements - A → Interface Implementation
            */
            #endregion

            #region Bouns 
            //Static Binding: The method to be called is determined at compile time

            //Dynamic Binding: The method to be called is determined at runtime
            #endregion
        }
    }
}
