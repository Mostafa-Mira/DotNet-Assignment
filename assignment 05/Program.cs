using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 01
            /*
            try
            {
                Console.WriteLine("Enter first number:");
                int X = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int Y = int.Parse(Console.ReadLine());

                int Z = X / Y;

                Console.WriteLine(Z);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Operation complete");
            }
            */
            #endregion

            #region problem 02
            //The finally block is used to execute code regardless of whether an exception occurs or not
            #endregion

            #region problem 03
            /*
            public static void TestDefensiveCode()
        {
            int X, Y, Z;

            do
            {
                Console.WriteLine("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

            do
            {
                Console.WriteLine("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Z = X / Y;
        }
        */
            #endregion

            #region problem 04
            // int.TryParse() is safer because it does not throw an exception if the input is invalid It returns false instead, while int.Parse() throws an exception
            #endregion

            #region problem 05
            /*
            int? X = null;

            int Y = X ?? 0;

            Console.WriteLine(X.HasValue);

            if (X.HasValue)
            {
                Console.WriteLine(X.Value);
            }
            */
            #endregion

            #region problem 06
            // InvalidOperationException
            #endregion

            #region problem 07 
            /*
            int[] arr = new int[5];

            try
            {
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range");
            }
            */
            #endregion

            #region problem 08
            // To avoid IndexOutOfRangeException when accessing an index that does not exist in the array
            #endregion

            #region problem 09
            /*
            int[,] arr = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine($"Row {i + 1} Sum = {sum}");
            }

            for (int j = 0; j < 3; j++)
            {
                int sum = 0;

                for (int i = 0; i < 3; i++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine($"Column {j + 1} Sum = {sum}");
            }
            */
            #endregion

            #region problem 10
            /*
            It is used to get the size of a specific dimension in a multi-dimensional array.

            GetLength(0) → number of rows
            GetLength(1) → number of columns
            */
            #endregion

            #region problem 11
            /*
            int[][] arr = new int[3][];

            arr[0] = new int[2];
            arr[1] = new int[3];
            arr[2] = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region problem 12
            // Jagged arrays allocate each row separately, so each row can have a different size

            //Rectangular arrays allocate one fixed-size block with the same number of elements in each row
            #endregion

            #region problem 13
            /*
            #nullable enable

            string? Name;

            string Input = Console.ReadLine();

            if (Input != "")
            {
                Name = Input;
            }
            else
            {
                Name = null;
            }

            Console.WriteLine(Name!);
            */
            #endregion

            #region problem 14
            // To help prevent NullReferenceException by warning when a reference type may contain null 
            #endregion

            #region problem 15
            /*
            int X = 10;

            object O = X;

            try
            {
                int Y = (int)O;
                Console.WriteLine(Y);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid Cast");
            }
            */
            #endregion

            #region problem 16
            // Boxing and unboxing have a performance cost because they require extra memory allocation and casting operations, which can affect performance if used frequently
            #endregion

            #region problem 17
            /*
            public static void SumAndMultiply(int N1, int N2, out int Sum, out int Mul)
        {
            Sum = N1 + N2;
            Mul = N1 * N2;
        }

        int X = 10, Y = 5, Sum, Mul;

        SumAndMultiply(X, Y, out Sum, out Mul);

        Console.WriteLine(Sum);
        Console.WriteLine(Mul);
            */
            #endregion

            #region problem 18
            // Because out parameters do not need to be initialized before calling the method, so they must be assigned a value inside the method
            #endregion

            #region problem 19
            /*
            public static void PrintMessage(string Message, int Repeat = 5)
        {
            for (int i = 0; i < Repeat; i++)
                Console.WriteLine(Message);
        }

        PrintMessage(Message: "Hello", Repeat: 3);
            */
            #endregion

            #region problem 20
            // Because required parameters must be provided first, so optional parameters are placed at the end to avoid ambiguity when calling the method
            #endregion

            #region problem 21
            /*
            int[]? arr = null;

            Console.WriteLine(arr?.Length);
            */
            #endregion

            #region problem 22
            // It checks if the reference is null before accessing its properties, so it prevents NullReferenceException
            #endregion

            #region problem 23
            /*
            string day = Console.ReadLine();

            int number = day switch
            {
                "Monday" => 1,
                "Tuesday" => 2,
                "Wednesday" => 3,
                "Thursday" => 4,
                "Friday" => 5,
                "Saturday" => 6,
                "Sunday" => 7,
                _ => 0
            };

            Console.WriteLine(number);
            */
            #endregion

            #region problem 24
            // When there are multiple conditions based on the same value, and you want a simpler and more readable way to return a result
            #endregion

            #region problem 25
            /*
            public static int SumArray(params int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        int[] arr = { 1, 2, 3 };

        Console.WriteLine(SumArray(arr));
        Console.WriteLine(SumArray(1, 2, 3));
            */
            #endregion

            #region problem 26
            // It must be the last parameter, and a method can have only one params parameter
            #endregion

            //                                                                                              Part 2

            #region problem 01
            /*
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i);

                if (i < N)
                    Console.Write(", ");
            }
            */
            #endregion

            #region problem 02
            /*
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(N * i);

                if (i < 12)
                    Console.Write(", ");
            }
            */
            #endregion

            #region problem 03
            /*
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i += 2)
            {
                Console.Write(i);

                if (i < N)
                    Console.Write(", ");
            }
            */
            #endregion

            #region problem 04
            /*
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int Result = 1;

            for (int i = 0; i < Y; i++)
            {
                Result *= X;
            }

            Console.WriteLine(Result);
            */
            #endregion

            #region problem 05
            /*
            string Text = Console.ReadLine();

            for (int i = Text.Length - 1; i >= 0; i--)
            {
                Console.Write(Text[i]);
            }
            */
            #endregion

            #region problem 06
            /*
            int N = int.Parse(Console.ReadLine());

            while (N > 0)
            {
                Console.Write(N % 10);
                N /= 10;
            }
            */
            #endregion

            #region problem 07
            /*
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int MaxDistance = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int Distance = j - i - 1;

                        if (Distance > MaxDistance)
                            MaxDistance = Distance;
                    }
                }
            }

            Console.WriteLine(MaxDistance);
            */
            #endregion

            #region problem 08 
            /*
            string Sentence = Console.ReadLine();

            string[] Words = Sentence.Split(' ');

            string Result = "";

            for (int i = Words.Length - 1; i >= 0; i--)
            {
                Result += Words[i];

                if (i > 0)
                    Result += " ";
            }

            Console.WriteLine(Result);
            */
            #endregion
        }
    }
}
