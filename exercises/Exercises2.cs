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
}