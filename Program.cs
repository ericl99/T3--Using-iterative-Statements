using System;
// T3- Using Iterative statements
// Erick Leon 02/02/22 ISM4300
// Table that converts CAD to USD
namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of CAD you want to convert to USD:");
            /* Use a try catch block to validate the users input
             with a catch block to handle user error input
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // Variable is current cad value
                decimal amount = decimal.Parse(input);
                // CAD value
                decimal CAD = 0;

                /* 
                   This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 5 and 25, a different type of 
                   iterative statement will execute. 
                */
                // If the value of user input is between 5 and 25, execute a For Loop
                if ((value_of_input > 4) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("This is how much USD you would get");
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                // If statement to see what the user inputed and converts it
                else if (amount > 4) && (amount <= 25)
                        {
                    CAD* amount;
                    // Tells you how much you will get in return
                    Console.WriteLine ("This is the amount of USD you would get"));

                }
                // If the user does not enter a value between 1 and 20, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 5 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace