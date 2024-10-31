﻿using System;

class Challenges
{
    public static void Main(string[] args)
    {
        bool continueProgram = true; // Declare the variable to control program loop

        while (continueProgram) // Start a loop to keep the program running
        {
            Console.WriteLine("\nWelcome to my coding challenge program.");
            Console.WriteLine("Please select a challenge from the list:");
            Console.WriteLine("1. Add two numbers (SUM)");
            Console.WriteLine("2. Convert minutes to seconds");
            Console.WriteLine("3. Add one to a number");
            Console.WriteLine("4. Calculate age in days");
            Console.WriteLine("5. Calculate the area of a triangle");
            Console.WriteLine("6. Determine if a number is less than or equal to zero");
            Console.WriteLine("7. Convert Voltage to Power");
            Console.WriteLine("8. Determine if the sum of two numbers is less than a hundred");
            Console.WriteLine("9. Determine if the your two value what where inputed are equal to eachother");
            Console.WriteLine("10. Write a word or a sentence that returns with something");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose SUM. Please input two numbers.");
                    Console.Write("Enter first number: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The sum of {num1} and {num2} is: {Sum(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine("You chose to convert minutes to seconds.");
                    Console.Write("Enter the number of minutes: ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{minutes} minutes is equal to {Convert(minutes)} seconds.");
                    break;
                case "3":
                    Console.WriteLine("You chose to add one to a number.");
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Adding one to {number} gives: {PlusOne(number)}");
                    break;
                case "4":
                    Console.WriteLine("You chose to calculate age in days.");
                    Console.Write("Enter your age in years: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{age} years is approximately {CalcAge(age)} days.");
                    break;
                case "5":
                    Console.WriteLine("You chose to calculate the area of a triangle.");
                    Console.Write("Enter the base of the triangle: ");
                    float baseLength = float.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the triangle is: {TriArea(baseLength, height)}");
                    break;
                case "6":
                    Console.WriteLine("You chose to determine if a number is less than or equal to zero.");
                    Console.Write("Enter a number: ");
                    int inputNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{inputNumber} is less than or equal to zero: {LessThanOrEqualToZero(inputNumber)}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid challenge from the list.");
                    break;
                case "7":

                    Console.WriteLine("Lets try converting voltage and current to power. \nGive me two numbers to convert from voltage and current to power");

                    var number1 = Console.ReadLine();
                    int number1int = int.Parse(number1);

                    var number2 = Console.ReadLine();
                    int number2int = int.Parse(number2);


                    Console.WriteLine(Voltage(number1int, number2int));
                    break;
                case "8":

                    Console.WriteLine("Input two numbers to determine if they are less than 100");

                    var number9 = Console.ReadLine();
                    int number9int = int.Parse(number9);

                    var number10 = Console.ReadLine();
                    int number10int = int.Parse(number10);

                    Console.WriteLine(LessThan100(number9int, number10int));
                    break;

                case "9":

                    Console.WriteLine("Input two numbers to find out if they are equal to eachother");

                    var number11 = Console.ReadLine();
                    int number11int = int.Parse(number11);

                    Console.WriteLine("Now input your second number");

                    var number12 = Console.ReadLine();
                    int number12int = int.Parse(number12);
                    Console.WriteLine("Are your two numbers equal to eachother? " + IsEqual(number11int, number12int));
                    break;

                case "10":
                   
                    
                        Console.WriteLine("now let's add somehting to the start of your word");
                        var words = Console.ReadLine();
                        Console.WriteLine(GiveMeSomething(words));
                    
                    break;





            }

            // Ask if the user wants to try another challenge
            Console.WriteLine("\nWould you like to try another challenge? (y/n)");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "y")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                continueProgram = false; // Ends the loop if user says 'n' 
            }
        }
    }

    // Challenge methods
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int minutes)
    {
        return minutes * 60;
    }

    public static int PlusOne(int number)
    {
        return number + 1;
    }

    public static int CalcAge(int years)
    {
        return years * 365;
    }

    public static float TriArea(float baseLength, int height)
    {
        return (baseLength * height) / 2;
    }

    public static bool LessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }
    public static int Voltage(int number1, int number2)
    {
        return number1 * number2;
    }

    public static bool LessThan100(int number9, int number10)
    {
        return number9 + number10 < 100;
    }

    public static bool IsEqual(int number11, int number12)
    {
        return number11 <= number12;
    }

    public static string GiveMeSomething(string words)
    {
        return "something " + words;
    }

    
}
