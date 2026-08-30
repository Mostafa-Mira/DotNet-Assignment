using System.Text;

namespace assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 01
            /*
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int num1 = int.Parse(input);
                int num2 = Convert.ToInt32(input);

                Console.WriteLine("by Parse: " + num1);
                Console.WriteLine("by Convert: " + num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input");
            */
            #endregion

            #region problem 02
            /*
            int.Parse() gives an exception when the input is null

            Convert.ToInt32() does not give an exception, it returns 0 when the input is null
            */
            #endregion

            #region problem 03
            /*
             Console.Write("Enter a number: ");
             string input = Console.ReadLine();

             if (int.TryParse(input, out int number))
             {
                Console.WriteLine(number);
             }
             else
             {
                Console.WriteLine("invalid number");
             }
            */
            #endregion

            #region problem 04
            // tryParse is better because it does not give an error when the user enters a wrong value,it returns false instead, so we can handle it easily.
            #endregion

            #region problem 05
            /*
            object value;
            value = 10;
            Console.WriteLine(value.GetHashCode());

            value = "Hello";
            Console.WriteLine(value.GetHashCode());

            value = 10.5;
            Console.WriteLine(value.GetHashCode());
            */
            #endregion

            #region problem 06
            // GetHashCode() gives a number for the object. It is used to help compare objects and find them quickly
            #endregion

            #region problem 07
            /*
            class Person
        {
            public string Name;
        }

        Person p1 = new Person();
        p1.Name = "Ahmed";

        Person p2 = p1;

        p1.Name = "Ali";

        Console.WriteLine(p2.Name);
            */
            #endregion

            #region problem 08
            // reference equality means that two variables point to the same object in memory
            #endregion

            #region problem 09
            /*
            string text = "Hello";

            Console.WriteLine(text.GetHashCode());

            text = text + " Hi Mostafa";

            Console.WriteLine(text.GetHashCode());
            */
            #endregion

            #region problem 10
            // String is immutable because its value cannot be changed after it is created, any change creates a new string
            #endregion

            #region problem 11
            /*
            StringBuilder text = new StringBuilder("Hello");

            Console.WriteLine(text.GetHashCode());

            text.Append(" Hi Mostafa");

            Console.WriteLine(text.GetHashCode());
            */
            #endregion

            #region problem 12
            // StringBuilder changes the same object instead of creating a new string every time
            #endregion

            #region problem 12
            // StringBuilder is faster because it changes the same object instead of creating a new object every time
            #endregion

            #region problem 13
            /*
            Console.Write("Enter first number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is " + (input1 + input2));

            Console.WriteLine(string.Format("Sum is {0}", input1 + input2));

            Console.WriteLine($"Sum is {input1 + input2}");
            */
            #endregion

            #region problem 14
            // String interpolation ($) is the most used because it is easy to write and read
            #endregion

            #region problem 15
            /*
            StringBuilder text = new StringBuilder("Hello Mostafa");

            text.Append("!");

            text.Replace("Mostafa", "Ahmed");

            text.Insert(6, "Mr. ");

            text.Remove(0, 6);

            Console.WriteLine(text);
            */
            #endregion

            #region problem 16
            // StringBuilder uses the same object when changing the text, so it is better for frequent modifications
            #endregion
        }
    }
    
}
