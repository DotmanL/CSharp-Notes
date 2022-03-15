using System;

//OOP -- OBJECTS INTERACTING WITH EACH OTHER, - ACTIONS ARE CREATED WITH METHODS
//namespace = collection of classes
//class Program---- contains method and data the progam is going to use
//Main - entry point/method for all csharp programs, method determine how the program behave
//string message ='abc', int intVar= 150, floatVar = 10.2f,
//char charVar ='E'  bool boolVar = false
//use doublequotes for strings
//Data type -
//value type - if it holds data value within its own memeory space
// or refernce type - doesn;t store the actual value, holds a reference to the address of the value in memory, stored in a heap 
//eg: of ref type - classes, objects, arrays, strings, interfces.


namespace app
{
    class LearningCsharp
    {
        static void Main(string[] args)
        {
            //Type Conversion -- Implicit -- smaller to larger data types, derive to base classes
            //Explicit-- larger to smaller data types, possible data loss
            //long is a data type that larger than int type, henc dat can be stored without truncated, compiller implicitly converts the value.
            // if long is not sufficient enough, compiler explicity solves this by CAST, complier try explicitly to make the conversion, data loss may occur 


            //implicit conversion - no data loss
            int num = 123456789;
            long newNum = num;

            //explicit conversion - data loss
            double x = 1234.5;
            int a = (int)x;

            //variable definition
            // string message = "Hello Dot";
            //or
            // string newMessage;
            // newMessage = "hello DotL";
            //or define multiple variables on the same line of the same tyoe
            // string firstName, lastName;

            //Constants -- cannot be changed 
            const double pi = 3.142;
            double r = 5;
            double area = pi * r * r;

            //operators - basic assignment, arithmetic, relational, logical, unary, tenary, bitwise & bit shift, compound assign
            double firstNr = 5, secondNr = 7, result;
            int num1 = 26, num2 = 4, reminder;

            //addition
            result = firstNr + secondNr;
            Console.WriteLine(result);

            //modulus operator 
            reminder = num1 % num2;
            Console.WriteLine(reminder);

            //Relational operator (==, >, <, >= !=) - returns a bool
            bool resNumber;
            int firstNumber = 10, secondNumber = 50;
            resNumber = (firstNumber == secondNumber);
            Console.WriteLine(resNumber);

            //Logical operators (OR-||, AND -&&)
            //or Example
            resNumber = (firstNumber == secondNumber) || firstNumber > 5;
            Console.WriteLine(resNumber);

            //and Example
            resNumber = (firstNumber == secondNumber) && firstNumber > 5;
            Console.WriteLine(resNumber);

            //unary operators -- either increase of decrease a value=(++, --, !)
            int uNumber = 20, uResult;
            uResult = ++uNumber;
            Console.WriteLine(uNumber);

            //ternary operatoors (? :, )
            int tNumber = 25;
            string tResult;
            tResult = (tNumber > 0) ? "Greater" : "Not Greater";
            Console.WriteLine(tResult);

            //BitWise & Bitshift operators - not really used

            //Compund assignment operators
            int cNumber = 10;

            cNumber += 5;
            Console.WriteLine(cNumber);

            cNumber <<= 5;
            Console.WriteLine(cNumber);

            cNumber >>= 5;
            Console.WriteLine(cNumber);


            Console.WriteLine("Hello World!");
            // Circle circle = new Circle();
            Console.WriteLine($"Size of int {sizeof(int)}");
            Console.WriteLine(newNum);
            Console.WriteLine(a);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
//Basic Syntax

// class Circle
// {
//member of this class stored with variables
//     double radius;
//     double pi =3.14;

//     public void AcceptRadius(){
//       radius = 4.5;

//     } 

//     public double GetArea()
//     {
//       return pi*radius*radius;
//     }  

//     public void ShowResults()
//     {
//       Console.WriteLine("Radius: {0}, radius");
//       Console.WriteLine("Area: {0}, GetArea()");
//     }
// }


