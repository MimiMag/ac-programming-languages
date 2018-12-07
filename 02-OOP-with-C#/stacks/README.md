# Working with stacks

## Assignment:
Write a C# console application that initializes that takes input from the user, numbers, puts them on the stack. When the user types r it will pop all items of the stack and displays them, each item on a new line. q will exit the program.

## Starter Code
```C#
static void Main()
{
    //Print initial messages when the program stars
    Console.WriteLine("Welcome to the program.");
    Console.WriteLine("Please input some numbers followed by <enter>. When you are done, press r to print the data structure, or input q to quit.");

    while (true)
    {
        //Read inputs from the command line
        //Waits until a line is being read from the console
        string inputFromConsole = Console.ReadLine();

        if (inputFromConsole == "r")
        {
            //Print 
            Console.WriteLine("Print");
            //Reset 
        }

        if (inputFromConsole == "q")
        {                 
            Console.WriteLine("Exiting... Bye!!");
            return;
        }

        //If the input can be parsed as an Integer
        if (int.TryParse(inputFromConsole, out int inputNumber))
        {
            //Add inputNumber to the data structure
            Console.WriteLine($"Added {inputNumber}.");
        }
    }
}
```

## TODO:
* [ ] Figure out how to test the `PopAllItems` method
* [ ] Figure out how to run the program in the terminal
