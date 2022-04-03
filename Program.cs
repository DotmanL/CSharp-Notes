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
        public static void Main(string[] args)
        {
            //Type Conversion -- Implicit -- smaller to larger data types, derive to base classes
            //Explicit-- larger to smaller data types, possible data loss
            //long is a data type that larger than int type, henc dat can be stored without truncated, compiller implicitly converts the value.
            // if long is not sufficient enough, compiler explicity solves this by CAST, complier try explicitly to make the conversion, data loss may occur 


            //implicit conversion - no data loss
            int num = 123456789;
            long newNum = num;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Size of int {sizeof(int)}");
            Console.WriteLine(newNum);

            //explicit conversion - data loss
            double x = 1234.5;
            int a = (int)x;

            Console.WriteLine(a);

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

            //Decison Statements
            //if, if/else, else/if, switch
            int numberif = 0;
            if (numberif > 0)
            {
                Console.WriteLine("It is a positive number");
            }
            else
            {
                Console.WriteLine("It is not a positive number");
            }

            //Else if example
            if (numberif > 0)
            {
                Console.WriteLine("It is a positive number");
            }
            else if (numberif > 0)
            {
                Console.WriteLine("It is not a negative number");
            }
            else
            {
                Console.WriteLine("It is 0");
            }

            //Switch statements(to avoid many if else statements
            string day = "Tues";

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It is Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It is Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It is Thursday");
                    break;
                default:
                    Console.WriteLine("It is a weekend");
                    break;
            }

            //Loops - for, while, do-while

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} - Hello from C#!");
            }
            //while
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine($"{j} - Hello from C#!");
                j += 2;
            }

            //do while -- code is executed at least one time
            int k = 1;
            do
            {
                Console.WriteLine($"{k} - Hello from C#!");
                k++;
            } while (k < 11);

            //Access modifiers - specify level at which variable, 
            // object or function can be accessed, five types which are
            // public, provate, protected, internal, protected internal
            // public class can be accessed anywhere within the application
            // private class can accessed from only within the class
            // protectd can only be accessed from within the defined class and child classes.
            //internal accesses from within same assembly, that is student class and program class
            // belong to the same assemblly
            //protected internal -- accessed from child classes within the same assembly
            //example


            Student student = new Student("John", "Smith", 20);
            Console.WriteLine($"First Name - {student.firstName}");

            Console.WriteLine($"Last Name - {student.lastName}");
            Console.WriteLine($"Age - {student.age}");

            //functions-- encapsulated a piece of code and call within our code
            // <visibility -- public/private><return type><name>(<parameters>)
         
            double firstSum = AddNumbers(10, 20);
            Console.WriteLine($"First Sum = {firstSum}");

            Hello();
    }
        //function example
        public static double AddNumbers(double a, double b) => a + b;
        
        // with no return type, use void
        public static void Hello()
        {
            Console.WriteLine("Hello from a void function");
        }
        
        
        //Access modifiers example
        public class Student
        {
            public string firstName;
            public string lastName;
            //private would make age not accessible outside the class 
            public int age;

            public Student(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }
        }
    }



   

}


