namespace excercises;

public class Exercises1()
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

    /*
        Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
    */

    public static void Orientation()
    {
        Console.WriteLine("Enter Length: ");
        var len = GetValue();

        Console.WriteLine("Enter Width: ");
        var wid = GetValue();

        if (len > wid)
        {
            System.Console.WriteLine("Portrait Orientation");
        }
        else
        {
            System.Console.WriteLine("Landscape Orientation");
        }

    }

    /*
        Your job is to write a program for a speed camera. 
        For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, program should display Ok on the console. 
        If the value is above the speed limit, the program should calculate the number of demerit points. 
        For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        If the number of demerit points is above 12, the program should display License Suspended.
    */

    public static void SpeedCamera()
    {
        System.Console.WriteLine("Enter Speed Limit: ");
        var speedLimit = GetValue();

        System.Console.WriteLine("Enter Vehicle Speed: ");
        var carSpeed = GetValue();

        if (carSpeed < speedLimit)
        {
            System.Console.WriteLine("OK");
            return;
        }
        else
        {
            var difference = carSpeed - speedLimit;
            var demerritPoints = difference / 5;

            if (demerritPoints > 12)
            {
                System.Console.WriteLine("Suspended");
                return;
            }

            System.Console.WriteLine("Demerrit Points: {0}", demerritPoints);

        }

    }

}