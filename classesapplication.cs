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
      this.name = "<No name yet>";
      this.sound = "<No sound yet>";
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

    //object method that we can access as example dog.toString() it will take the dogs information and display it when we call it. (the mothod is excecuted!)
    public string toString(){
      return String.Format("{0} is {1} inches tall, weights {2} pounds and likes to say {3}", name, height, weight,sound);
    }

    //method overloading. work with different attribute types but also use the same method name. It will be able to accep integers or double variable types under the same mothod's name.
    public int getSum(int num1 = 0, int num2 = 0){
      return num1 + num2;
    }
    public double getSum(double num1 = 0, double num2 = 0){
      return num1 + num2;
    }


    static public void Main ()
    {

      // ------------CLass Animal -----------------------------------
      //create new animal!
      // Animal perro = new Animal(2, 200, "perro", "rouf-rouf");
      // Console.WriteLine("{0} says {1}", perro.name, perro.sound);

      // Console.WriteLine("Please enter the following information to create your own pet or Animal!");
      // Console.Write("Name = ");
      // var name = Console.ReadLine();

      // Console.Write("Animal height = ");
      // int height = int.Parse(Console.ReadLine());
      
      // Console.Write("Animal weight = ");
      // int weight = int.Parse(Console.ReadLine());

      // Console.Write("Animal sound = ");
      // var sound = Console.ReadLine();

      // Animal newAnimal = new Animal(height,weight,name, sound);
      // Console.WriteLine("{0} says {1}", newAnimal.name, newAnimal.sound);    

      // //you can call the static method to know how many animal were created
      // Console.WriteLine("Number of animals created is: "+ Animal.getNumOfAnimals());

      // Console.WriteLine("Info about your animal" + perro.toString());

      // Console.WriteLine("Info about your animal" + newAnimal.toString());

      // //calling overloading methods
      // Console.WriteLine("Integers Sum: " + newAnimal.getSum(1,1));
      // Console.WriteLine("Integers Sum: " + newAnimal.getSum(1.1,1.1));

      // //creating a new animal
      // Animal cat = new Animal{
      //   name = "cat",
      //   height = 21,
      //   weight = 322,
      //   sound = "GRGRGRGRGRRRRRRR!!!!!!"
      // };

      // Console.WriteLine("cdhcbdsjkcd" + cat.toString());


      // // ------------ CLass Dog -----------------------------------
      // //we can create a sub CLass of animal. Examples dog, cat, whale...
      // //this sub class is going to inherit all the methods and attributes that his parent class Animal has.

      // Dog irishSetter = new Dog();
      // Console.WriteLine("info about my new dog " + irishSetter.toString());      
      // irishSetter = new Dog(2, 200, "Lucas", "rouf-rouf", "pizza");
      // Console.WriteLine("info about my new dog" + irishSetter.toString());      

      // -------------- generics - GEneric Class ---------------------
      KeyValue<string, string> superman = new KeyValue<string,string>("","");

      superman.key = "Superman";
      superman.value = "Clark Kent";

      KeyValue<int, string> samsungtv = new KeyValue<int, string>(0,"");

      samsungtv.key = 100;
      samsungtv.value = "Diego's 50' Samsung TV";

      superman.showData();
      samsungtv.showData();
    }
  }

  class Dog : Animal {
    // we can add dogs own attributes that only dogs can have
    public string favFood{ get; set; }

    //create a custom constructor set favFood
    //note we can call the super class with :base() --> to get all initializations in super class. 
    public Dog():base(){
      this.favFood = "<No favourite yet>";
    }

    //we can create a more elavorate constructor for Dog taking in considerations Animal class
    public Dog(double height, double weight, string name, string sound, string favFood):base(height, weight, name, sound){
      this.favFood = favFood; 
    }

    // overwrite methods from a parent Class. To over write we have to type new at the beginning of method
    new public string toString(){
      return String.Format("{0} is {1} inches tall, weights {2} pounds and likes to say {3} and favourite food is {4}", name, height, weight,sound, favFood);
    }

  }
  // Generics - Generic Class (no need to specify the datatype of an elelment in a class or method.)

  class KeyValue<Tkey, TValue>{
    public Tkey key {get; set;}
    public TValue value {get; set;}

    // constructor
    public KeyValue(Tkey k, TValue v ){
      key = k;
      value = v;
    }

    public void showData(){
      Console.WriteLine("{0} is {1}", this.key, this.value);
    }


  }
}






