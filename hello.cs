using System;
using System.Collections.Generic;
 
public class HelloWorld
{
  static public void Main ()
  {
    // //start lecture ----------------------------------------
    // Console.Write ("Please enter your name: ");

    // //use string variables ----------------------------------------
    // string name = Console.ReadLine();
    // Console.WriteLine ("Hello " + name + " what is going on!");
    // Console.Write ("Please enter your age :");
    // string age = Console.ReadLine();
    // Console.WriteLine ( name + "," + " you are " + age +" years old!");

    // // use general variable and then assign type--------------------------
    // var somevartiable = "This is a string variable";
    // Console.WriteLine (somevartiable);
    // Console.WriteLine ("somevartiable is a {0}", somevartiable.GetTypeCode());

    // // math operations----------------------------------------
    // Console.WriteLine("(5 + 5 ) = " + (5 + 5));
    // Console.WriteLine("(5 - 5 ) = " + (5 - 5));
    // Console.WriteLine("(5 % 2) = " + (5 % 2));

    // int i = 0;

    // Console.WriteLine(" i++ = " + (i++));
    // Console.WriteLine("new value for i = " + i);

    // i = 10;

    // Console.WriteLine("i += 3 = " , (i += 3));

    // //casting ----------------------------------------
    // double pi = 3.1415;
    // Console.WriteLine("pi = " + pi);
    // int intPi = (int)pi;
    // Console.WriteLine("intPi = " + intPi);

    // // math functions
    // Console.WriteLine("Math.Sqrt(intPi) = " +  (Math.Sqrt(intPi)));
    // Console.WriteLine("Math.Round(pi) = " +  (Math.Round(pi)));

    // //generate random numbers----------------------------------------
    // Random rand = new Random();
    // Console.WriteLine("random number between 1 to 10 = " + rand.Next(1,11)); 

    // //conditions ----------------------------------------
    // Console.WriteLine("Please enter your age again! : ");
    // var age_string = Console.ReadLine();
    // int age = Int32.Parse(age_string);
    // if (age < 30){
    //   Console.WriteLine("Good age!, age = " + age);
    // }
    // else if (age == 30){
    //   Console.WriteLine("This is your actual age!");
    // }
    // else{
    //   Console.WriteLine("What is wrong with you!");
    // }


    // Console.WriteLine("What is todys day of the week?");
    // var day = Console.ReadLine().ToLower();
    // switch (day){
    //   case "monday":
    //     Console.WriteLine("Monday time to go to work!");
    //     break;

    //   case "friday":
    //     Console.WriteLine("Friday time to party!");
    //     break;

    //   default:
    //     Console.WriteLine("plan your weekend nowwwwww.");
    //     break;
    // }



    // looping ----------------------------------------
    // int a = 0;
    // while( a < 10){
    //   Console.WriteLine(a);
    //   if (a == 7){
    //     Console.WriteLine("a is seven!");
    //   }
    //   a++;
    // }

    // Random rand = new Random();
    // string guess;
    // int number;
    // do{
    //   Console.WriteLine("Guess a number between 1 to 5 : ");
    //   guess = Console.ReadLine();
    //   number = Int32.Parse(guess);
    // } while (! number.Equals(rand.Next(1,6)));

    // for (int i= 0; i <= 10 ; i++){
    //   Console.WriteLine(i);
    // }

    // Console.WriteLine("Enter your name to iterate through: ");
    // string name = Console.ReadLine();

    // foreach (char i in name){
    //   Console.WriteLine(i);
    // }


    // // working with strings ----------------------------------------
    // Console.WriteLine("Enter a word or sentence : ");
    // string name = Console.ReadLine();

    // Console.WriteLine("Lenght of input with diego in it: " + (name.Length));
    // Console.WriteLine("index (like an array) of input: " + (name.IndexOf("diego")));
    // Console.WriteLine("pull diego fom input: " + (name.IndexOf("diego")));
    // Console.WriteLine("trimming last part from input: " + (name.TrimEnd()));

    // // string builder be able to adit without creating a new one
    // // StringBuilder sb = new StringBuilder();

    // // sb.Append("This is an eppended text!");
    // // sb.AppendFormat("My name is {0} and I live in {1}", "Diego", "Vancouver");

    // // Arrays ----------------------------------------

    // // declare array
    // int[] array1;

    // // declare array with number of items in it (3 items in this case)
    // int[] array2 = new int[3];
    // //declare and initialize an array
    // int[] array3 = {1,2,3,45};

    // Console.WriteLine("array3 Length : ", array3.Length);

    // for(int i = 0; i < array3.Length; i++ ){
    //   // Console.WriteLine(array3[i]);
    // }

    // int[,] multiArray = {{2,3}, {4,5}, {5,2}};

    // for (int x = 0; x < multiArray.GetLength(0); x++ ){
    //   for (int y = 0; y < multiArray.GetLength(1); y++ ){
    //     Console.WriteLine("{0} | {1} : {2}", x, y, multiArray[x,y]);
    //   }
    // }


    // list ----------------------------------------

    // create list with type of data
    // List<int> numList = new List<int>(5);
    List<int> numList = new List<int>(5);

    // add items to list
    numList.Add(5);

    // add array to list
    int[] array4 = {10,12,13,44};
    numList.AddRange(array4);

    // numList.Clear();

    // copy an array into a list
    List<int> numList2 = new List<int>(array4);

    for (var i = 0; i < numList2.Count; i++){
      Console.WriteLine("{0} : {1}", i, numList2[i]);
    }

    //note when creating a list or array need to declare it and call new and declar it again. 
    List<string> stringList = new List<string>(new string[] {"diego", "herrera", "ceron"});

    for (var i = 0; i < stringList.Count; i++){
      Console.WriteLine(" {0} : {1}", i, stringList[i]);
    }

    //you can sort them out!
    stringList.Sort();
    for (var i = 0; i < stringList.Count; i++){
      Console.WriteLine(" {0} : {1}", i, stringList[i]);
    }



  }
}













