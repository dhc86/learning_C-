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
    }
}