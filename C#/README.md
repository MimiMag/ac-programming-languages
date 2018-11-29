# C\#

## Why C\#

## C\# Characteristics
* The language consists of **statements**, which are terminated by semicolons.  A statement can declare a variable, define an expression, perform a simple action by calling a method, control the flow of execution of other statements, create an object, or assign a value to a variable, property, or field. For example:
```C#
int sampleVariable;                           // declaring a variable
```  

* A **block of code**, is a series of statements surrounded by curly braces.

* Data Structures
  *  ``` enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };``` <br/>
    The elements in the above enumeration are then available as constants:
    ```
    Weekday day = Weekday.Monday;

    if (day == Weekday.Tuesday)
    {
        Console.WriteLine("Time sure flies by when you program in C#!");
    }
    ```
  * Structures (keyword struct) are light-weight objects. They are mostly used when only a data container is required for a collection of value type variables. Structs are similar to classes in that they can have constructors, methods, and even implement interfaces, but there are important differences. <br/>
  Structs are value types while classes are reference types, which means they behave differently when passed into methods as parameters. <br/>
  Structs cannot support inheritance. While structs may appear to be limited with their use, they require less memory and can be less expensive, if used in the proper way. <br/>
  Structs always have a default constructor, even if you don't want one. Classes allow you to hide the constructor away by using the "private" modifier, whereas structures must have one. <br>
  A struct can, for example, be declared like this:
  ```
  struct Person
  {
      public string name;
      public System.DateTime birthDate;
      public int heightInCm;
      public int weightInKg;
  }
  ```

  * Arrays represent a set of items all belonging to the same type. The declaration itself may use a variable or a constant to define the length of the array. However, an array has a set length and it cannot be changed after declaration.
  ```
  // an array whose length is defined with a constant
  int[] integers = new int[20];

  int length = 0;
  System.Console.Write("How long should the array be? ");
  length = int.Parse(System.Console.ReadLine());
  // an array whose length is defined with a variable
  // this array still can't change length after declaration
  double[] doubles = new double[length];
  ```


## Checkout 
  * Managed language & Garbage Selector
  * .Net (tools that make this language run on your computer)


## Useful Sources:
* [C# syntax](https://en.wikibooks.org/wiki/C_Sharp_Programming/Syntax)
* [C# variables](https://en.wikibooks.org/wiki/C_Sharp_Programming/Variables)
