using System;

// A simple class full of navigation goodies!
public class NavigationExamples
{
    public int SomeInt { get; private set; } = 10;
    public float SomeFloat { get; private set; } = 10.0f;

    public void ImportantFunction()
    {
        Console.WriteLine("This does important work!!");
    }

    public void AnotherImportantFunction()
    {
        Console.WriteLine("This does equally important work!!");
    }

    public void MovementPlayground()
    {
        // Moving around a line of code!
        string someString = "This is a string!";

        // Moving around a WORD of code
        string someStringWihtALongNaem = "Now this string has a long name!";

        // Navigating around a scope of code!
        if(someString == "wrong string")
        {
            // Do a bunch of nonsense!
            Console.WriteLine("That's the wrong string!");
            Console.WriteLine("Here's some nonsense");
            Console.WriteLine("Here's some more nonsense");
        }
        else
        {
            Console.WriteLine("That's not the wrong string!");
        }

        Console.WriteLine(someStringWihtALongNaem);
    }
}