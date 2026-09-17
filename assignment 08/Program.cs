using System.Runtime.Intrinsics.X86;

namespace assignment_08
{
    internal class Program
    {

        #region problem 03 part 2

        public static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }

            series.ResetSeries();
        }
        
        #endregion

        static void Main(string[] args)
        {
            #region problem 01
            /*
            IVehicle vehicle;

            vehicle = new Car();
            vehicle.StartEngine();
            vehicle.StopEngine();

            vehicle = new Bike();
            vehicle.StartEngine();
            vehicle.StopEngine();
            */
            #endregion

            #region problem 02
            // It makes the code more flexible and allows it to work with different classes
            #endregion

            #region problem 03
            /*
            Shape shape;

            shape = new Rectangle();
            shape.Display();
            Console.WriteLine(shape.GetArea());

            shape = new Circle();
            shape.Display();
            Console.WriteLine(shape.GetArea());
            */
            #endregion

            #region problem 04
            //When you need shared code or data between related classes, an abstract class is a better choice
            #endregion

            #region problem 05
            /*
            Product[] products =
            {
            new Product { Id = 1, Name = "Laptop", Price = 20000 },
            new Product { Id = 2, Name = "Mouse", Price = 500 },
            new Product { Id = 3, Name = "Keyboard", Price = 1000 }
            };

            Array.Sort(products);

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }
            */
            #endregion

            #region problem 06
            // It allows objects to define their own sorting rule, so Array.Sort() can sort them based on the required criteria
            #endregion

            #region problem 07
            /*
            Student student1 = new Student(1, "Mostafa", 90);

            Student student2 = student1;

            Student student3 = new Student(student1);

            student2.Name = "Ahmed";
            student3.Name = "Ali";

            Console.WriteLine(student1.Name);
            Console.WriteLine(student2.Name);
            Console.WriteLine(student3.Name);
            */
            #endregion

            #region problem 08
            // To create a new object by copying the data from an existing object
            #endregion

            #region problem 09
            /*
            Robot robot = new Robot();
            robot.Walk();

            IWalkable walkable = robot;
            walkable.Walk();
            */
            #endregion

            #region problem 10
            // It allows the same method name to have different implementations for different interfaces
            #endregion

            #region problem 11
            /*
            Account account = new Account();

            account.AccountId1 = 1;
            account.AccountHolder1 = "Mostafa";
            account.Balance1 = 5000;

            Console.WriteLine(account.AccountId1);
            Console.WriteLine(account.AccountHolder1);
            Console.WriteLine(account.Balance1);
            */
            #endregion

            #region problem 12
            // The key difference is that **structs are value types**, while **classes are reference types**. Both can use encapsulation through private fields and public properties
            #endregion

            #region problem 13
            // Abstraction means hiding unnecessary details and showing only what is needed
            // Encapsulation protects the data, while abstraction hides the implementation details
            #endregion

            #region problem 14
            /*
            ILogger logger = new ConsoleLogger();

            logger.Log();
            */
            #endregion

            #region problem 15
            // They allow adding new methods to an interface without forcing existing classes to implement them
            #endregion

            #region problem 16
            /*
            Book book1 = new Book();
            Book book2 = new Book("C#");
            Book book3 = new Book("C#", "Mostafa");

            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Title);
            Console.WriteLine(book3.Title);
            Console.WriteLine(book3.Author);
            */
            #endregion

            #region problem 17
            // It allows objects to be created in different ways depending on the available data
            #endregion

            //                                                                                           PART 2

            #region problem 01
            // Coding against an interface rather than a class means you make your code depend on the interface (contract) instead of a specific class
            //So you can later use another class without changing the main code

            // Code against abstraction, not concreteness means the same idea: depend on abstract concepts(interface/abstract class) rather than specific implementations(concrete classes)
            #endregion

            #region problem 02
            //Abstraction means hiding implementation details and depending on general concepts instead of specific classes.We can implement it using interfaces and abstract classes
            #endregion

            #region problem 03 part 2
            /*
            IShapeSeries series = new SquareSeries();

            PrintTenShapes(series);

            series = new CircleSeries();

            PrintTenShapes(series);
            */
            #endregion

            #region problem 04
            /*
            ShapeSort[] Shapes =
            {
                 new ShapeSort() { Name = "Square", Area = 25 },
                 new ShapeSort() { Name = "Circle", Area = 12.5 },
                 new ShapeSort() { Name = "Rectangle", Area = 40 }
            };

            Array.Sort(Shapes);

            foreach (ShapeSort S in Shapes)
            {
                Console.WriteLine($"{S.Name} : {S.Area}");
            }
            */
            #endregion


        }
    }
}
