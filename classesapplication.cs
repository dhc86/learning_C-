using System;
using System.Collections.Generic;
 
public class ClassesAplication
{
  class Animal
  {

    //here we define properties for class Animal
    // we can limit access to different properties. public (access not limited) and protected (access to specific class method). Subclass methods.
    public double height { get; set; }
    public double weight { get; set; }
    public string sound { get; set; }

    // create your own getters ans setters
    public string name;
    public string Name{
      get{return name;}
      //value is default for setting any item
      set{ name = value; }
    }
    
    //note with getters and setters we can limit access with get ot set value with setting.

    //now we need a way to initialize these new animal objects. We use a Constructor. The default constructor is automaticly created for you unless you create one of your own. 
    //initilizer
    public Animal(){
      this.height = 0;
      this.weight = 0;
      this.name = "No name";
      this.sound = "No sound";
      numOfAnimals++;
    }

    // COnstuctor to set our vatriables or attributes 
    public Animal(double height, double weight, string name, string sound){
      this.height = height;
      this.weight = weight;
      this.name = name;
      this.sound = sound;
      numOfAnimals++;
    }

    // we can track the number of objects created from the Animal class. You create a static field when you want to have the capability to get information about the class. Animal do not need to have this capability this opperation and therefore they do not need this attribute. For this we create a static field.
    // define it
    static int numOfAnimals = 0;
    //get access to static value using a static method. Note static methods can NOT access non static class members. Only static. 
    public static int getNumOfAnimals(){
      return numOfAnimals;
    }


    public string toString(){
      return String.Format("{0} is {1} inches tall, weights {2} pounds and likes to say {3}", name, height, weight,sound);
    }



    static public void Main ()
    {

      //create new animal!
      Animal perro = new Animal(2, 200, "perro", "rouf-rouf");
      Console.WriteLine("{0} says {1}", perro.name, perro.sound);

      Console.WriteLine("Please enter the following information to create your own pet or Animal!");
      Console.Write("Name = ");
      var name = Console.ReadLine();

      Console.Write("Animal height = ");
      int height = int.Parse(Console.ReadLine());
      
      Console.Write("Animal weight = ");
      int weight = int.Parse(Console.ReadLine());

      Console.Write("Animal sound = ");
      var sound = Console.ReadLine();

      Animal newAnimal = new Animal(height,weight,name, sound);
      Console.WriteLine("{0} says {1}", newAnimal.name, newAnimal.sound);    

      //you can call the static method to know how many animal were created
      Console.WriteLine("Number of animals created is: "+ Animal.getNumOfAnimals());

      Console.WriteLine("Info about your animal" + perro.toString());

      Console.WriteLine("Info about your animal" + newAnimal.toString());





    }
  }
}






