using System;
using System.Text;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region problem 01

            // This program adds two numbers and prints the result.
            int x = 10;
            int y = 20;
            /*
            add x and y together
            and store the result in sum.
            */
            int sum = x + y;

            Console.WriteLine(sum);//Print the sum
            #endregion

            #region problem 02
            //The shortcut to comment a selected block of code is Ctrl + K, Ctrl + C, and to uncomment it is Ctrl + K, Ctrl + U.
            #endregion

            #region problem 03
            /*The errors are:

           1- "10" is a string, so it should be 10
           2- y is not defined
           3- console should be Console (C) must be capital

           Correct code:

            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);
            */
            #endregion

            #region problem 04
            /*
            A runtime error happens when the program is running and causes the program to stop

            Example:

            int x = 10 / 0;

            A logical error means the code runs, but gives the wrong result

            Example:

            int x = 10;
            int y = 20;
            Console.WriteLine(x - y); ==> Wrong result if we want to add them
            */
            #endregion

            #region problem 05
            //string fullName = "Mostafa Esmail";
            //int age = 18;
            //double monthlySalary = 0;
            //bool isStudent = true;
            #endregion

            #region problem 06
            //It is important because it makes the code easy to read and understand
            #endregion

            #region problem 07
            /*
            class Person
        {
            public string name;
        }

        Person person1 = new Person();
        person1.name = "Ahmed";

        Person person2 = person1;

        person2.name = "Ali";

        Console.WriteLine(person1.name);
        The output is ==> "Ali"
            */
            #endregion

            #region problem 08
            /*
            Value types store the actual value in memory, while reference types store a reference to the object in memory

            Example:

            int x = 10;  ==> Value type

            Person p = new Person(); ==> Reference type
            */
            #endregion

            #region problem 09
            /*
            int x = 15; 
            int y = 4;
            Console.WriteLine("Sum: " + (x + y));
            Console.WriteLine("Difference: " + (x - y));
            Console.WriteLine("Product: " + (x * y));
            Console.WriteLine("Division: " + (x / y));
            Console.WriteLine("Remainder: " + (x % y));
            */
            #endregion

            #region problem 10
            //The output is: 2 , Because % gives the remainder after division, 2 divided by 7 = 0, and the remainder is 2.
            #endregion

            #region problem 11
            /*
            int num = 12
            if (num > 10 && num %2==0)
            {
                Console.WriteLine("The number is greater than 10 and even.");
            }
            else
            {
                Console.WriteLine("The number does not meet both conditions.");
            }
            */
            #endregion

            #region problem 12
            //&& is used to check two conditions. Both conditions must be true.
            //& is used with numbers and works with their bits.
            #endregion

            #region problem 13
            /*
            double number = double.Parse(Console.ReadLine());
            int expnum = (int)number;
            double impnum = expnum;
            Console.WriteLine("Explicit: " + expnum);
            Console.WriteLine("Implicit: " + implnum);
            */
            #endregion

            #region problem 14
            // Explicit casting is needed because double can have decimal numbers, but int cannot. The decimal part is removed when converting to int.
            #endregion

            #region problem 15
            /*
            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);

            if (age > 0)
            {
                Console.WriteLine("Valid age");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
            */
            #endregion

            #region problem 16
            /*
              If the user enters invalid input, a FormatException may occur
              We can handle it using (try & catch)
            */
            #endregion

            #region problem 17
            /*
            int x = 5;

            Console.WriteLine(++x); ==> Prefix (6)
            Console.WriteLine(x++); ==> Postfix (6)
            Console.WriteLine(x); (7)
            */
            #endregion

            #region problem 18
            /*
            ++x ==> first increase x from 5 to 6 and use 6
            x++ ==> first use 6 (value) then increase x from 6 to 7 

            now x = 7 , y = 6+6=12
            */
            #endregion

        }
    }
}