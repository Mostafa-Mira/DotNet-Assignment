using System.ComponentModel;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_10
{
    internal class Program
    {

        #region problem 05
        /*
        public static bool CompareLengthAsc(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }
        */
        #endregion

        #region problem 07
        /*
        class Manager : Employee, IComparable<Manager>
        {
            public Manager(int _id, string _name, double _salary)
                : base(_id, _name, _salary)
            {
            }

            public int CompareTo(Manager other)
            {
                return Salary.CompareTo(other.Salary);
            }
        }
        */
        #endregion

        #region problem 13
        /*
        static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        */
        #endregion

        #region problem 15
        /*
        public static bool CompareEmployee(Employee X, Employee Y)
        {
            if (X.Salary != Y.Salary)
                return X.Salary > Y.Salary;

            return string.Compare(X.Name, Y.Name) > 0;
        }
        */
        #endregion

        #region problem 21
        /*
        public delegate string StringTransformDelegate(string Str);

        static List<string> TransformStrings(List<string> Strings, StringTransformDelegate Transform)
        {
            List<string> Result = new List<string>();

            foreach (string Str in Strings)
            {
                Result.Add(Transform(Str));
            }

            return Result;
        }
        */
        #endregion

        #region problem 17
        /*
        static T GetDefault<T>()
        {
            return default(T);
        }
        */
        #endregion

        #region problem 23
        /*
        public delegate int MathDelegate(int X, int Y);

        static int Calculate(int X, int Y, MathDelegate Operation)
        {
            return Operation(X, Y);
        }
        */
        #endregion

        #region problem 25
        /*
        public delegate R TransformDelegate<T, R>(T Value);

        static List<R> Transform<T, R>(List<T> Items, TransformDelegate<T, R> TransformFunc)
        {
            List<R> Result = new List<R>();

            foreach (T Item in Items)
            {
                Result.Add(TransformFunc(Item));
            }

            return Result;
        }
        */
        #endregion

        #region problem 29
        /*
        static void PrintStrings(List<string> Strings, Action<string> Action)
        {
            foreach (string Str in Strings)
            {
                Action(Str);
            }
        }
        */
        #endregion

        #region problem 31
        /*
        static List<int> FilterNumbers(List<int> Numbers, Predicate<int> Check)
        {
            List<int> Result = new List<int>();

            foreach (int Number in Numbers)
            {
                if (Check(Number))
                    Result.Add(Number);
            }

            return Result;
        }
        */
        #endregion

        #region problem 32
        /*
        static List<string> FilterStrings(List<string> Strings, Predicate<string> Condition)
        {
            List<string> Result = new List<string>();

            foreach (string Str in Strings)
            {
                if (Condition(Str))
                    Result.Add(Str);
            }

            return Result;
        }
        */
        #endregion

        #region problem 35
        /*
        static int Calculate(int X, int Y, Func<int, int, int> Operation)
        {
            return Operation(X, Y);
        }
        */
        #endregion

        #region problem 37
        /*
        static List<string> FilterStrings(List<string> Strings, Predicate<string> Condition)
        {
            List<string> Result = new List<string>();

            foreach (string Str in Strings)
            {
                if (Condition(Str))
                    Result.Add(Str);
            }

            return Result;
        }
        */
        #endregion

        #region problem 39
        /*
        static double Calculate(double X, double Y, Func<double, double, double> Operation)
        {
            return Operation(X, Y);
        }
        */
        #endregion
        static void Main(string[] args)
        {
            // فاهم ان لازم يكون فيه كلاس موجود من الاساس بس السؤال بيقول استخدم ف مش لازم اعمل كلاس عشان الوقت بصراحة

            #region problem 01
            /*
            Employee[] Emps =
            {
                new Employee(1, "Ali", 4567),
                new Employee(2, "Abdo", 9567),
                new Employee(3, "Ismail", 3567)
            };

            SortingAlgorithm<Employee>.Sort(Emps);

            foreach (Employee item in Emps)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 02
            // Generic sorting is better because it can work with different data types, is reusable, and provides type safety
            #endregion

            #region problem 03
            /*
            int[] Nums = { 1, 5, 3 };

            SortingTwo<int>.Sort(Nums, (X, Y) => X < Y);

            foreach (int item in Nums)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 04
            // Lambda expressions make sorting easier to read and more flexible because we can change the sorting rule directly without changing the sorting method
            #endregion

            #region problem 05
            /*
            string[] Names = { "Ali", "Abdo", "Mahmoud", "Ahmed" };

            SortingTwo<string>.Sort(Names, CompareLengthAsc);

            foreach (string item in Names)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 06
            // It allows the sorting method to work with different data types and different sorting rules without changing the sorting algorithm
            #endregion

            #region problem 07
            /*
            Manager[] Managers =
            {
                new Manager(1, "Ali", 9000),
                new Manager(2, "Abdo", 12000),
                new Manager(3, "Ismail", 7000)
            };

            SortingAlgorithm<Manager>.Sort(Managers);

            foreach (Manager item in Managers)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 08
            // It allows the derived class to define how its objects are compared and sorted, such as sorting by Salary
            #endregion

            #region problem 09
            /*
            Employee[] Emps =
            {
                new Employee(1, "Ali", 5000),
                new Employee(2, "Mahmoud", 7000),
                new Employee(3, "Abdo", 6000)
            };

            Func<Employee, Employee, bool> CompareNameLength =
                (X, Y) => X.Name.Length > Y.Name.Length;

            SortingTwo<Employee>.Sort(Emps, CompareNameLength);

            foreach (Employee item in Emps)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 10
            // Built-in delegates like Func are easy to use, reusable, and work with different data types without creating a custom delegate
            #endregion

            #region problem 11
            /*
            #region Anonymous Function

            int[] Nums = { 5, 3, 8, 4, 2 };

            Func<int, int, bool> CompareAsc =
                delegate (int X, int Y)
                {
                    return X > Y;
                };

            SortingTwo<int>.Sort(Nums, CompareAsc);

            foreach (int item in Nums)
                Console.WriteLine(item);

            #endregion

            #region Lambda Expression

            int[] Nums2 = { 5, 3, 8, 4, 2 };

            Func<int, int, bool> CompareAsc2 = (X, Y) => X > Y;

            SortingTwo<int>.Sort(Nums2, CompareAsc2);

            foreach (int item in Nums2)
                Console.WriteLine(item);

            #endregion
            */
            #endregion

            #region problem 12
            // Anonymous functions are longer and less readable, while lambda expressions are shorter, clearer, and easier to use. Both have similar performance
            #endregion

            #region problem 13
            /*
            int[] Nums = { 1, 2, 3, 4, 5 };

            Swap(ref Nums[0], ref Nums[1]);

            foreach (int item in Nums)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 14
            // Generic methods are useful because they can work with different data types without writing the same method again
            #endregion

            #region problem 15
            /*
            Employee[] Emps =
            {
                new Employee(1, "Ali", 5000),
                new Employee(2, "Mahmoud", 7000),
                new Employee(3, "Abdo", 5000),
                new Employee(4, "Ahmed", 7000)
            };

            SortingTwo<Employee>.Sort(Emps, CompareEmployee);

            foreach (Employee item in Emps)
                Console.WriteLine(item);
            */
            #endregion

            #region problem 16
            // The main challenge is writing more complex comparison logic. The benefit is that the generic method can sort different data types using multiple criteria without changing the sorting algorithm
            #endregion

            #region problem 17
            /*
            int Number = GetDefault<int>();
            string Name = GetDefault<string>();

            Console.WriteLine(Number);
            Console.WriteLine(Name);
            */
            #endregion

            #region problem 18
            // default(T) is important because it gives the default value for any generic type. For value types, it returns values like 0, while for reference types, it returns null
            #endregion

            #region problem 19
            /*
            Employee[] Emps =
            {
                new Employee(1, "Ali", 5000),
                new Employee(2, "Abdo", 7000),
                new Employee(3, "Ismail", 6000)
            };

            Employee[] EmpsClone = Emps
                .Select(E => (Employee)E.Clone())
                .ToArray();

            SortingAlgorithm<Employee>.Sort(EmpsClone);

            foreach (Employee item in EmpsClone)
                Console.WriteLine(item);

            + تعديل كود الكلاس بس الكلاس مش موجود هنا

            */

            #endregion

            #region problem 20
            // Constraints ensure that only valid types can be used with generic methods. This provides type safety and makes the code more reliable by preventing invalid operations
            #endregion

            #region problem 21
            /*
            List<string> Names = new List<string> { "Ali", "Ahmed", "Mostafa" };

            List<string> UpperNames = TransformStrings(Names, Str => Str.ToUpper());

            foreach (string Name in UpperNames)
                Console.WriteLine(Name);

            List<string> ReversedNames = TransformStrings(Names, Str => new string(Str.Reverse().ToArray()));

            foreach (string Name in ReversedNames)
                Console.WriteLine(Name);
            */
            #endregion

            #region problem 22
            // Delegates make string transformations more flexible and reusable. They allow us to change the transformation logic without changing the main method
            #endregion

            #region problem 23
            /*
            int Result1 = Calculate(10, 5, (X, Y) => X + Y);
            int Result2 = Calculate(10, 5, (X, Y) => X - Y);
            int Result3 = Calculate(10, 5, (X, Y) => X * Y);
            int Result4 = Calculate(10, 5, (X, Y) => X / Y);

            Console.WriteLine(Result1);
            Console.WriteLine(Result2);
            Console.WriteLine(Result3);
            Console.WriteLine(Result4);
            */
            #endregion

            #region problem 24
            // Delegates make the same method reusable with different mathematical operations. They also make the code flexible because we can change the operation without changing the main method
            #endregion

            #region problem 25
            /*
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };

            List<string> Strings = Transform(Numbers, X => X.ToString());

            foreach (string Item in Strings)
                Console.WriteLine(Item);
            */
            #endregion

            #region problem 26
            // Generic delegates make data transformation reusable for different data types. They provide flexibility and type safety without writing separate methods for each type
            #endregion

            #region problem 27
            /*
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };

            Func<int, int> Square = X => X * X;

            List<int> Results = new List<int>();

            foreach (int Number in Numbers)
            {
                Results.Add(Square(Number));
            }

            foreach (int Result in Results)
                Console.WriteLine(Result);
            */
            #endregion

            #region problem 28
            // Func removes the need to create a custom delegate. It makes delegates easier to write and use, especially for simple operations
            #endregion

            #region problem 29
            /*
            List<string> Names = new List<string> { "Ali", "Ahmed", "Mostafa" };

            Action<string> Print = Str => Console.WriteLine(Str);

            PrintStrings(Names, Print);
            */
            #endregion

            #region problem 30
            // Action is preferred because it is designed for methods that perform an operation without returning a value. It makes the code simple and clear
            #endregion

            #region problem 31
            /*
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Predicate<int> IsEven = Number => Number % 2 == 0;

            List<int> EvenNumbers = FilterNumbers(Numbers, IsEven);

            foreach (int Number in EvenNumbers)
                Console.WriteLine(Number);
            */
            #endregion

            #region problem 32
            // Predicates are used to check conditions and return `true` or `false`. They make functional code clearer by separating the condition from the main logic
            #endregion

            #region problem 33
            /*
            List<string> Names = new List<string>
            {
                "Ali", "Ahmed", "Abdo", "Mostafa", "Mahmoud"
            };

            List<string> StartsWithA = FilterStrings(
                Names,
                delegate (string Str)
                {
                    return Str.StartsWith("A");
                });

            foreach (string Name in StartsWithA)
                Console.WriteLine(Name);

            List<string> ContainsMo = FilterStrings(
                Names,
                delegate (string Str)
                {
                    return Str.Contains("mo", StringComparison.OrdinalIgnoreCase);
                });

            foreach (string Name in ContainsMo)
                Console.WriteLine(Name);
            */
            #endregion

            #region problem 34
            // Anonymous functions improve modularity by keeping specific logic separate from the main method. They also allow customization by changing the behavior without modifying the main function
            #endregion

            #region problem 35
            /*
            Func<int, int, int> Add =
                delegate (int X, int Y)
                {
                    return X + Y;
                };

            Func<int, int, int> Subtract =
                delegate (int X, int Y)
                {
                    return X - Y;
                };

            Func<int, int, int> Multiply =
                delegate (int X, int Y)
                {
                    return X * Y;
                };

            Console.WriteLine(Calculate(10, 5, Add));
            Console.WriteLine(Calculate(10, 5, Subtract));
            Console.WriteLine(Calculate(10, 5, Multiply));
            */
            #endregion

            #region problem 36
            // Prefer anonymous functions when the operation is simple and used only once. Named methods are better when the operation is complex or reused in many places
            #endregion

            #region problem 37
            /*
            List<string> Names = new List<string>
            {
                "Ali", "Ahmed", "Omar", "Mostafa", "Eman"
            };

            List<string> LengthGreaterThan3 =
                FilterStrings(Names, Str => Str.Length > 3);

            foreach (string Name in LengthGreaterThan3)
                Console.WriteLine(Name);

            List<string> ContainsE =
                FilterStrings(Names, Str => Str.Contains("e", StringComparison.OrdinalIgnoreCase));

            foreach (string Name in ContainsE)
                Console.WriteLine(Name);
            */
            #endregion

            #region problem 38
            // Lambda expressions make code shorter, clearer, and more flexible. They are useful for passing simple logic to methods, especially with delegates and LINQ
            #endregion

            #region problem 39
            /*
            double Division = Calculate(10, 2, (X, Y) => X / Y);

            double Power = Calculate(2, 3, (X, Y) => Math.Pow(X, Y));

            Console.WriteLine(Division);
            Console.WriteLine(Power);
            */
            #endregion

            #region problem 40
            // Lambda expressions make mathematical operations shorter and clearer. They allow us to write the calculation directly where it is needed
            #endregion

            //                                                                                                              Part 02

            #region 1. Parallel Programming and Concurrency
            /*
            Parallel Programming means running multiple parts of a program at the same time to improve performance.

            Concurrency means handling multiple tasks during the same period.The tasks do not always have to run at exactly the same time.
            
            In C#, we can use Task and Parallel to work with multiple tasks and improve the use of CPU resources.
            */
            #endregion

            #region Unit Testing and Test-Driven Development (TDD)
            /*
            Unit Testing is testing a small part of a program, such as a method, to make sure it works correctly.

            TDD(Test - Driven Development) is a development approach where we write the test before writing the actual code.
            
            The common TDD cycle is:
            
            Red → Green → Refactor
            
            Red: Write a test that fails.
            Green: Write code to make the test pass.
            Refactor: Improve the code while keeping the test passing.
            
            Unit testing helps find errors early and makes the code easier to maintain.
            */
            #endregion

            #region Asynchronous Programming with async and await
            /*
            Asynchronous Programming allows a program to perform time-consuming operations without blocking the current thread.

            In C#, we use async and await with Task to handle asynchronous operations such as API calls, database operations, and file operations.
            
            Example:

            async Task<string> GetDataAsync()
            {
                string result = await GetDataFromApiAsync();
                return result;
            }

            The await keyword waits for the operation to finish without blocking the thread
            */
            #endregion

            //                                                                                                          Part 03 (Bouns)

            #region Bouns
            /*
             Asynchronous Programming** means performing a task without blocking the program while waiting for it to finish
             For example, when getting data from an API or database, the program can continue doing other work instead of waiting. In C#, we usually use async and await for this.
             */
            #endregion
        }
    }
}
