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
            Console.WriteLine("18.Write a word or a sentence that returns with Hello");
            Console.WriteLine("19.Input the number of animals you have(chickens,cows,and pigs)");
            Console.WriteLine("20.Input the number of (wins,draws,and losses) you have to determine the points your team has in the league.");
            Console.WriteLine("21. Enter a number to get the corresponding month");
            Console.WriteLine("22. Find the minimum and maximum in an array");
            Console.WriteLine("23. sum up all the numbers in a array");
            Console.WriteLine("24. provide a base and exponent and return the calculation ");
            Console.WriteLine("25. multiply all values in a array by the aount of values in the array");
            Console.WriteLine("26. Input 2 words to see how many letters they have different.")




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

                    if (firme <= 2)
                    {
                        Console.WriteLine("The number needs to be 2 or more on the dead lokas");
                    }
                    else if (firme > 2)
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


                case "18":


                    Console.WriteLine("now let's add hello to the start of your word");
                    var words2 = Console.ReadLine();
                    Console.WriteLine(HelloLeva(words2));


                    break;

                case "19":

                    Console.WriteLine("Tell me how many chickens, cows, and pigs");
                    Console.Write("Enter the chickens : ");
                    int num17 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the cows  : ");
                    int num18 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the pigs  : ");
                    int num19 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The legs of the animals are {num17} chicken legs , {num18} cow legs , and {num19} pig legs is equal to : {fam(num17, num18, num19)} legs!");
                    break;

                case "20":

                    Console.WriteLine("Input the amount of wins, draws and loses you have");
                    Console.Write("Enter the amount of wins : ");
                    int num20 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount of draws : ");
                    int num21 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount of loses  : ");
                    int num22 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The wins are {num20} , {num21} the draws are , and the losses are {num22} whihc is equal to : {footballfoo(num20, num21, num22)} points!");
                    break;
                case "21":
                    Console.WriteLine("You chose Month Selector. Enter a number between 1 and 12:");
                    if (int.TryParse(Console.ReadLine(), out int monthNumber))
                    {
                        string monthName = months(monthNumber);
                        if (monthName != null)
                        {
                            Console.WriteLine($"The month for number {monthNumber} is {monthName}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number. Please enter a number between 1 and 12.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "22":
                    Console.WriteLine("You chose to find the minimum and maximum in an array.");
                    Console.WriteLine("Enter numbers separated by commas (EXAMPLE: 1,2,3,4): ");
                    string input = Console.ReadLine();
                    int[] numbers = input.Split(',').Select(int.Parse).ToArray();
                    int[] result = FindMinMax(numbers);
                    Console.WriteLine($"The minimum number is {result[0]} and the maximum number is {result[1]}.");
                    break;

                case "23":
                    {
                        Console.WriteLine("Now we are going to get the absolute value of numbers");
                        var number23 = Console.ReadLine();
                        int number23int = int.Parse(number23);
                        Console.WriteLine("Give me your second number");
                        var number24 = Console.ReadLine();
                        int number24int = int.Parse(number24);
                        Console.WriteLine("Give me your third number");
                        var number25 = Console.ReadLine();
                        int number25int = int.Parse(number25);
                        Console.WriteLine("Give me your last number");
                        var number26 = Console.ReadLine();
                        int number26int = int.Parse(number26);
                        Console.WriteLine("Your Array of " + number23 + "," + number24 + "," + number25 + "," + number26 + " added all together is " + LosJunior(number23int, number24int, number25int, number26int));
                        break;


                    }

                case "24":
                    Console.WriteLine("preovide a base and a power to solve a exponent .");
                    Console.Write("enter the base(s): ");
                    double baseNumber = int.Parse(Console.ReadLine());
                    Console.Write("enter the power: ");
                    int exponent = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The returned calculation is: {Power(baseNumber, exponent)}");
                    break;
                case "25":

                    // This case represents your scenario with multiplying by length
                    Console.WriteLine("You chose to multiply all values in the array by the number of values in the array.");
                    Console.WriteLine("Enter numbers separated by commas (EXAMPLE: 1,2,3,4): ");

                    // Read user input and assign it to a unique variable
                    string userInput = Console.ReadLine();

                    // Split the input string and parse it into an array of integers
                    int[] numArray = userInput.Split(',').Select(int.Parse).ToArray();

                    // Get the length of the array
                    int arrayLength = numArray.Length;

                    // Multiply each value in the array by the length of the array
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        numArray[i] *= arrayLength;
                    }

                    // Output the modified array
                    Console.WriteLine("The modified array is: " + string.Join(", ", numArray));
                    break;
                case "26":

                    Console.WriteLine("You chose to calculate the Hamming Distance.");
                    Console.WriteLine("Enter the first string: ");
                    string str1 = Console.ReadLine();

                    Console.WriteLine("Enter the second string: ");
                    string str2 = Console.ReadLine();

                    int distance = HammingDistance(str1, str2);

                    if (distance != -1) // Check for valid computation
                    {
                        Console.WriteLine($"The Hamming Distance between the strings is: {distance}");
                    }
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
        if (a == true && b == true)
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

    public static string HelloLeva(string words2)
    {
        return "Hello " + words2 + "!";
    }



    public static int fam(int number17, int number18, int number19)
    {
        return number17 * 2 + number18 * 4 + number19 * 4;
    }

    public static int footballfoo(int number20, int number21, int number22)
    {
        return number20 * 3 + number21 * 1 + number22 * 0;
    }
    public static string months(int number)
    {
        switch (number)
        {
            case 1: return "January";
            case 2: return "February";
            case 3: return "March";
            case 4: return "April";
            case 5: return "May";
            case 6: return "June";
            case 7: return "July";
            case 8: return "August";
            case 9: return "September";
            case 10: return "October";
            case 11: return "November";
            case 12: return "December";
            default: return null;





        }
    }

    public static int[] FindMinMax(int[] arr)
    {
        int min = arr.Min();
        int max = arr.Max();
        return new int[] { min, max };
    }
    static double Power(double baseNumber, int exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }
    public static int LosJunior(int number23, int number24, int number25, int number26)
    {
        return (Math.Abs(number23)) + (Math.Abs(number24)) + (Math.Abs(number25)) + (Math.Abs(number26));
    }
    public static int[] MultiplyByLength(int[] arr)
    {
        int length = arr.Length; // Get the length of the array
        int[] result = new int[length]; // Create a new array to hold the results

        for (int i = 0; i < length; i++)
        {
            result[i] = arr[i] * length; // Multiply each element by the length of the array
        }

        return result; // Return the new array with the multiplied values
    }
    // Hamming distance function
    public static int HammingDistance(string str1, string str2)
    {
        // Check if strings are the same length
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("wrong length foo");
            return -1; // Return an error value
        }

        // Compute the Hamming distance
        int hammingDistance = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) // Compare each character
            {
                hammingDistance++; // Increment for differences
            }
        }

        return hammingDistance; // Return the calculated distance
    }






}










