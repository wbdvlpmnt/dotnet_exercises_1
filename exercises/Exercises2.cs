using System.Diagnostics.SymbolStore;

namespace excercises;

public class Exercises2()
{
    /*
    1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    Display the count on the console.
    */

    public static void DivisibleBy3()
    {
        int count = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }

        System.Console.WriteLine("There are {0} numbers between 0-100 that are divisible by 3", count);
    }

    /*
    2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
    Calculate the sum of all the previously entered numbers and display it on the console.
    */

    public static void EnterNumbers()
    {
        int sum = 0;
        int inputNumber;
        var input = "";

        while (input != "ok")
        {
            System.Console.WriteLine("Please enter a number or enter ok to exit:");
            input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out inputNumber);

            if (isNumber)
            {
                sum += inputNumber;
                System.Console.WriteLine("Total is: {0}", sum);
            }
        }
    }

    /*
    3- Write a program and ask the user to enter a number. 
    Compute the factorial of the number and print it on the console. 
    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    */
    public static void ComputeFactorial()
    {
        var input = "";
        int number;
        System.Console.WriteLine("Enter a number to find it's factorial");
        input = Console.ReadLine();

        bool isNumber = int.TryParse(input, out number);

        if (!isNumber)
        {
            return;
        }

        int result = 1;
        int originalNumber = number;
        while (number > 0)
        {

            result = number * result;
            number--;
        }

        System.Console.WriteLine("{0}! = {1}", originalNumber, result);
    }
}