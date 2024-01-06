namespace excercises;

public class Exercises()
{

    public static int GetValue()
    {
        var input = Console.ReadLine();
        int number;

        bool isNumber = int.TryParse(input, out number);

        if (!isNumber)
        {
            System.Console.WriteLine("Invalid Number");
            return 0;
        }

        return number;

    }

    /*
    Write a program and ask the user to enter a number. The number should be between 1 to 10. 
    If the user enters a valid number, display "Valid" on the console. 
    Otherwise, display "Invalid". 
    */

    public static void CheckValue()
    {
        System.Console.WriteLine("Please enter a number between 1 and 10:");
        int number = GetValue();

        bool rangeCondition = number > 0 && number <= 10;
        if (!rangeCondition)
        {
            System.Console.WriteLine("Number must be between 1-10");
            return;
        }

        System.Console.WriteLine("Valid");

    }

    /*
        Write a program which takes two numbers from the console and displays the maximum of the two.
    */

    public static void FindMax()
    {

        Console.WriteLine("Enter first number:");
        int number1 = GetValue();


        Console.WriteLine("Enter second number:");
        int number2 = GetValue();

        var maxNumber = number1 > number2 ? number1 : number2;
        System.Console.WriteLine("The maximum number is {0}", maxNumber);

    }

}