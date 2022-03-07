using System;

//OOP -- OBJECTS INTERACTING WITH EACH OTHER, - ACTIONS ARE CREATED WITH METHODS
//namespace = collection of classes
//class Program---- contains method and data the progam is going to use
//Main - entry point/method for all csharp programs, method determine how the program behave
//Data types -- https://www.tutorialsteacher.com/csharp/csharp-data-types
//string message ='abc', int intVar= 150, floatVar = 10.2f,
//char charVar ='E'  bool boolVar = false
//use doublequotes for strings
//Data type -
//value type - if it holds data value within its own memeory space
// or refernce type - doesn;t store the actual value, holds a reference to the address of the value in memory, stored in a heap 
//eg: of ref type - classes, objects, arrays, strings, interfces.


namespace app
{
    class Program
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
        double x= 1234.5;
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
       double area = pi*r*r;

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


