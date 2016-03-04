using System;
 
public class HelloWorld
{
  static public void Main ()
  {
    // //start lecture
    // Console.Write ("Please enter your name: ");

    // //use string variables 
    // string name = Console.ReadLine();
    // Console.WriteLine ("Hello " + name + " what is going on!");
    // Console.Write ("Please enter your age :");
    // string age = Console.ReadLine();
    // Console.WriteLine ( name + "," + " you are " + age +" years old!");

    // // use general variable and then assign type
    // var somevartiable = "This is a string variable";
    // Console.WriteLine (somevartiable);
    // Console.WriteLine ("somevartiable is a {0}", somevartiable.GetTypeCode());

    // // math operations
    // Console.WriteLine("(5 + 5 ) = " + (5 + 5));
    // Console.WriteLine("(5 - 5 ) = " + (5 - 5));
    // Console.WriteLine("(5 % 2) = " + (5 % 2));

    // int i = 0;

    // Console.WriteLine(" i++ = " + (i++));
    // Console.WriteLine("new value for i = " + i);

    // i = 10;

    // Console.WriteLine("i += 3 = " , (i += 3));

    //casting 
    double pi = 3.1415;
    Console.WriteLine("pi = " + pi);
    int intPi = (int)pi;
    Console.WriteLine("intPi = " + intPi);

    // math functions
    Console.WriteLine("Math.Sqrt(intPi) = " +  (Math.Sqrt(intPi)));
    Console.WriteLine("Math.Round(pi) = " +  (Math.Round(pi)));

    //generate random numbers
    Random rand = new Random();
    Console.WriteLine("random number between 1 to 10 = " + rand.Next(1,11)); 



  }
}













