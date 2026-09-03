namespace assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 01
            /*
            int[] arr01 = new int[3];
            arr01[0] = 10;
            arr01[1] = 20;
            arr01[2] = 30;

            Console.WriteLine(arr01[0]);
            Console.WriteLine(arr01[1]);
            Console.WriteLine(arr01[2]);


            int[] arr02 = new int[3] { 40, 50, 60 };

            Console.WriteLine(arr02[0]);
            Console.WriteLine(arr02[1]);
            Console.WriteLine(arr02[2]);


            int[] arr03 = { 70, 80, 90 };

            Console.WriteLine(arr03[0]);
            Console.WriteLine(arr03[1]);
            Console.WriteLine(arr03[2]);


            Console.WriteLine(arr01[3]);
            */
            #endregion

            #region problem 02
            //The default value of array elements depends on the data type.For int, it is 0
            #endregion

            #region problem 03
            /*
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            arr2 = arr1;
            arr1[0] = 10;

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            arr2 = (int[])arr1.Clone();

            arr1[0] = 20;

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);
            */
            #endregion

            #region problem 04
            //Clone() ==> creates a new array with the same elements

            //Copy() ==> copies a specified number of elements from one array to another existing array
            #endregion

            #region problem 05
            /*
            int[,] grades = new int[3, 3];

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter grade for student {i + 1}, subject {j + 1}:");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.WriteLine($"Grades for student {i + 1}:");

                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.WriteLine(grades[i, j]);
                }
            }
            */
            #endregion

            #region problem 06
            //Length ==> returns the total number of elements in the array

            //GetLength(dimension) ==> returns the number of elements in a specific dimension
            #endregion

            #region problem 07
            /*
            int[] arr = { 5, 2, 8, 1, 4 };

            Console.WriteLine("Before Sort:");
            foreach (int i in arr)
                Console.WriteLine(i);

            Array.Sort(arr);

            Console.WriteLine("After Sort:");
            foreach (int i in arr)
                Console.WriteLine(i);


            Array.Reverse(arr);

            Console.WriteLine("After Reverse:");
            foreach (int i in arr)
                Console.WriteLine(i);


            Console.WriteLine("Index of 4:");
            Console.WriteLine(Array.IndexOf(arr, 4));


            int[] arr2 = new int[5];

            Array.Copy(arr, arr2, 3);

            Console.WriteLine("After Copy:");
            foreach (int i in arr2)
                Console.WriteLine(i);


            Array.Clear(arr, 0, 2);

            Console.WriteLine("After Clear:");
            foreach (int i in arr)
                Console.WriteLine(i);
            */
            #endregion

            #region problem 08
            //Array.Copy() ==> copies elements from one array to another

            //Array.ConstrainedCopy() ==> also copies elements, but guarantees that if the copy fails, the destination array remains unchanged
            #endregion

            #region problem 09
            /*
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            int j = arr.Length - 1;

            while (j >= 0)
            {
                Console.WriteLine(arr[j]);
                j--;
            }
            */
            #endregion

            #region problem 10
            // Because foreach is simpler, cleaner, and does not require index management
            #endregion

            #region problem 11
            /*
            int Num;
            bool flag;

            do
            {
                Console.WriteLine("Write a positive odd number");
                flag = int.TryParse(Console.ReadLine(), out Num);
            }
            while (!flag || Num <= 0 || Num % 2 == 0);
            */
            #endregion

            #region problem 12
            // Because it prevents invalid input and helps the program handle user input safely without errors
            #endregion

            #region problem 13
            /*
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region problem 14
            // By using nested loops and spaces or tabs to align rows and columns
            #endregion

            #region problem 15
            /*

            int month;
            int.TryParse(Console.ReadLine(), out month);

            if (month == 1)
                Console.WriteLine("January");
            else if (month == 2)
                Console.WriteLine("February");
            else if (month == 3)
                Console.WriteLine("March");
            else if (month == 4)
                Console.WriteLine("April");
            else if (month == 5)
                Console.WriteLine("May");
            else if (month == 6)
                Console.WriteLine("June");
            else if (month == 7)
                Console.WriteLine("July");
            else if (month == 8)
                Console.WriteLine("August");
            else if (month == 9)
                Console.WriteLine("September");
            else if (month == 10)
                Console.WriteLine("October");
            else if (month == 11)
                Console.WriteLine("November");
            else if (month == 12)
                Console.WriteLine("December");
            else
                Console.WriteLine("Invalid month");

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
            */
            #endregion

            #region problem 15 but another way
            /*
            Console.WriteLine("Enter month numebr");
            int monthNum;
            if (int.TryParse(Console.ReadLine(), out monthNum))
            {
                if (monthNum > 0 && monthNum < 13)
                {
                    switch (monthNum)
                    {
                        case 1:
                            Console.WriteLine("Month:January");
                            break;
                        case 2:
                            Console.WriteLine("Month: February");
                            break;
                        case 3:
                            Console.WriteLine("Month: March");
                            break;
                        case 4:
                            Console.WriteLine("Month: April");
                            break;
                        case 5:
                            Console.WriteLine("Month: May");
                            break;
                        case 6:
                            Console.WriteLine("Month: June");
                            break;
                        case 7:
                            Console.WriteLine("Month: July");
                            break;
                        case 8:
                            Console.WriteLine("Month: August");
                            break;
                        case 9:
                            Console.WriteLine("Month: September");
                            break;
                        case 10:
                            Console.WriteLine("Month: October");
                            break;
                        case 11:
                            Console.WriteLine("Month:November");
                            break;
                        case 12:
                            Console.WriteLine("Month: December");
                            break;
                    }

                    if (monthNum == 1 || monthNum == 2 || monthNum == 3)
                    {
                        Console.WriteLine("Quarter: First Quarter");
                    }
                    else if (monthNum == 4 || monthNum == 5 || monthNum == 6)
                    {
                        Console.WriteLine("Quarter: Second Quarter");
                    }
                    else if (monthNum == 7 || monthNum == 8 || monthNum == 9)
                    {
                        Console.WriteLine("Quarter: Third Quarter");
                    }
                    else
                    {
                        Console.WriteLine("Quarter: Fourth Quarter");
                    }
                }

                else
                {
                    Console.WriteLine("invalid input");
                }
            }

            else
            {
                Console.WriteLine("invalid input");
            }
            */

            #endregion

            #region problem 16
            // When you have one variable compared against multiple fixed values
            #endregion

            #region problem 17
            /*
            int[] Num = { 9, 3, 10, 2, 8, 10, 6, 5, 1 };

            Array.Sort(Num);

            int Index = Array.IndexOf(Num, 10);
            Console.WriteLine(Index);

            int Index2 = Array.LastIndexOf(Num, 10);
            Console.WriteLine(Index2);
            */
            #endregion

            #region problem 18
            // The time complexity of Array.Sort() is O(n log n)
            #endregion

            #region problem 19
            /*
            int[] arr = { 1, 2, 3, 4, 5 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);

            sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            */
            #endregion

            #region problem 20
            // for is slightly more efficient because it directly accesses array elements using indexes, while foreach has a small overhead
            #endregion

            #region problem 02 in part 2
            /*
            enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        int num = int.Parse(Console.ReadLine());

        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), num.ToString());

        Console.WriteLine(day);
            */
            #endregion

            #region problem 03 in part 2
            //It will throw an error because the value does not match any enum value from 1 to 7
            #endregion

        }
    }
}
