using System;
 
public class HelloWorld
{
    static public void Main ()
    {
        Console.Write ("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine ("Hello " + name + " what is going on!");
        Console.Write ("Please enter your age :");
        string age = Console.ReadLine();
        Console.WriteLine ( name + "," + " you are " + age +" years old!");
        var somevartiable = "This is a string variable";
        Console.WriteLine (somevartiable);
        Console.WriteLine ("somevartiable is a {0}", somevartiable.GetTypeCode());
        Console.WriteLine("(5 + 5 ) = " + (5 + 5));
        Console.WriteLine("(5 - 5 ) = " + (5 - 5));
        Console.WriteLine("(5 % 2) = " + (5 % 2));

        int i = 0;

        Console.WriteLine(" i++ = " + (i++));
        Console.WriteLine("new value for i = " + i);

        i = 10;

        Console.WriteLine("i += 3 = " , (i += 3));
    }
}