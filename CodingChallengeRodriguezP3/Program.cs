using System;

class Challenges
{ 
    

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome To My Coding Challenge Program. There will be a variety of different function you will have choose from. Please Pick One");

        Console.WriteLine(" Today we are going to use the number pattern called sum please input 2 numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a Second number.");
        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));

        // converting minutes into seconds

        Console.WriteLine("Lets try converting minutes to seconds. \nGive me a numbver to convert from minutes to seconds");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int));

        Sum(number1int, number2int);

        // adding one to your number


        Console.WriteLine("Lets try add one to a number");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine(number4 + " One added to your number is " + Plusone(number4int));

        // volatage x current into power

        Console.WriteLine("Lets try converting voltage and current to power. \nGive me two numbers to convert from volatage and current to power");


        var number5 = Console.ReadLine();
        int number5int = int.Parse(number5);
        int number5int = int.Parse(number5);

        var number6 = Console.ReadLine();
        int number6int = int.Parse(number6);

        Console.WriteLine (multiply(number5int , number6int));

        // multiply 365 x your age

        Console.WriteLine("Type in your age to see how many days you have lived");

        var number7 = Console.ReadLine();
        int number7int = int.Parse(number7);

        Console.WriteLine(multiply(number7int));

        Console.WriteLine("That's how many days you have lived!");


        // area of a triangle 

        Console.WriteLine("Input the base and height of your triangles!");
        Console.WriteLine("Please Input the base of your triangle!");


        var number8 = Console.ReadLine();
        int number8int = int.Parse(number8);

        Console.WriteLine("Great!! Now Input the height of your triangle!");

        var number9 = Console.ReadLine();
        int number9int = int.Parse(number9);

        Console.WriteLine(triangle(number8int , number9int));

        Console.WriteLine("The area of your triangle with a base of " + number8 + " and a height of " + number9 + " is: " + (triangle(number8int, number9int)));

       // true or false

        Console.WriteLine(" Input a number to determine if it is less than or equal to Zero. \n Input A Number ");

        var number10 = Console.ReadLine();
        int number10int = int.Parse(number10);

        Console.WriteLine(number10 + " = " + lessThanOrEqualToZero(number10int));

        





    }

    // number plus a number

    public static int Sum(int number1, int number2)
    { 
        return number1 + number2; 
    
    }

    // convert minutes into seconds

    

    public static int Convert(int number)
    {
        return number * 60;
    }
    
    
    // a number plus one
   

    public static int Plusone(int number)
    {
        return number + 1;
    }

    // voltage and current

    public static int multiply(int number5, int number6)
    {
        return number5 * number6;
    }

    // find out how many days you have lived

    public static int multiply(int number7)
    {
        return number7 * 365;

    }

    // area of a triangle

    public static float triangle(float number8, int number9)
    {
        return (number8 * number9) / 2;
    }

    // see if a number is less than or equal to zero

    public static bool lessThanOrEqualToZero(int number10)
    {
        return (number10 <= 0) ? true : false;
        
    }

}
    
        





