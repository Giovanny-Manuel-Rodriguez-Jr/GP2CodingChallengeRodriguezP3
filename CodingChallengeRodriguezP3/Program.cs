using System;

class Challenges
    // loksz
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
            Console.WriteLine("10.Write a word or a sentence that returns with something");
            Console.WriteLine("11.The function reverses a boolean value");
            Console.WriteLine("12.Input a number to find out how many seconds are in the hours inputed in");
            Console.WriteLine("13.Determine The Degrees Of Internal Angles Depedning On The Amount Of Sides \n The Shape Has.");
            Console.WriteLine("14.Write a word or a sentence that returns your sentence with edabit at the end of it.");
            Console.WriteLine("15.Input a combenation of a and b to determine if it is true or false.");
            Console.WriteLine("16.Input the amount of 3 and 2 pointers scored,to determine your final score.");
            Console.WriteLine("17.Input your lenght and width to determine the perimeter of your rectangle.");

            //  loksz
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

                case "11":

                    Console.WriteLine("Lets reverse a boolean");
                    var trueorfalse = Console.ReadLine();
                    

                    
                    if (trueorfalse == "true")
                    {
                            Console.WriteLine("Its false");
                    }
                    else if (trueorfalse == "false")
                    {
                            Console.WriteLine("Its True");
                    }
                    else
                    {
                            Console.WriteLine("Try again maybe you mispelled something");
                    }
                    


                    break;

                case "12":
                    Console.WriteLine("Let's Find out how many seconds are in the amount of hours u input.");
                    Console.Write("Enter an amount of hour(s): ");
                    int time = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{time} hours is {CalcHour(time)} in seconds.");
                    break;

                case "13":
                    Console.WriteLine("Please input the number of sides your shape has.");
                    int firme = int.Parse(Console.ReadLine());

                    if(firme <= 2)
                    {
                        Console.WriteLine("The number needs to be 2 or more on the dead lokas");
                    }
                    else if(firme > 2)
                    {
                        Console.WriteLine($"The Number of {firme} is {SumPolygon(firme)} in internal angles.");
                    }
                    

                    
                    break;



                case "14":


                    Console.WriteLine("now let's add Edabit to the end of your word");
                    var words1 = Console.ReadLine();
                    Console.WriteLine(Mubashir(words1));

                    break;

                case "15":

                    Console.WriteLine(" Now input a combination of true or false neta pa dead lokas");
                        var a = Console.ReadLine();
                    bool abool = bool.Parse(a);
                    Console.WriteLine("Enter True or False again");
                    var b = Console.ReadLine();
                    bool bbool = bool.Parse(b);
                    Console.WriteLine("And (" + a + ", " + b + ") -> " + Papasdeadlokas(abool, bbool) + ".");
                    
                    break;


                case "16":

                    Console.WriteLine(" Determine how many points you scored");
                    Console.Write("Enter your amount of 2 pointers: ");
                    int num13 = int.Parse(Console.ReadLine());
                    Console.Write("Enter your amount of 3 pointers: ");
                    int num14 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The amount of 2 pointers is {num13} and 3 points is {num14} Which is equal to : {PepeTheSureño(num13, num14)} points!");
                    break;


                case "17":

                    Console.WriteLine(" Determine how many points you scored");
                    Console.Write("Enter your length : ");
                    int num15 = int.Parse(Console.ReadLine());
                    Console.Write("Enter your width  : ");
                    int num16 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The Perimeter of the numbers {num15} and {num16} is equal to : {Chaks(num15, num16)} feet!");
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

    public static int CalcHour(int time)
    {
        return time * 3600;
    }

    public static int SumPolygon(int firme)
    {
        return (firme - 2) * 180;
    }

    public static string Mubashir(string words1)
    {
        return words1 + "Edabit";
    }

    public static bool Papasdeadlokas(bool a, bool b)
    {
        if(a== true && b == true)
        {
            Console.WriteLine("True");
            return true;
          
        }
        else
        {
            Console.WriteLine("False");
            return false;
        }
    }

    public static int PepeTheSureño(int number13, int number14)
    {
        return number13 * 2 + number14 * 3;
    }

    public static int Chaks(int number15, int number16)
    {
        return number15 * 2 + number16 * 2;
    }




}
