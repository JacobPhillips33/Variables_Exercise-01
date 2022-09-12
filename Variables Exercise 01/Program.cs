using System;
using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // DONE: Declare 3 constansts

            const double pi = 3.14;
            const char myChar = '$';
            const bool myBool = true;

            Console.WriteLine(pi);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);

            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion

            // DONE: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            string theString = "This is a string.";
            char theChar = '@';
            bool theBool = false;
            int theInt = 33;
            double theDouble = 1.37;
            decimal theDecimal = 0.0000345m;

            // DONE Above (declared and initialized simultaneously): Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console

            Console.WriteLine(theString);
            Console.WriteLine(theChar);
            Console.WriteLine(theBool);
            Console.WriteLine(theInt);
            Console.WriteLine(theDouble);
            Console.WriteLine(theDecimal);

        }

    }
}
