using System;

public class SelectionExamples
{
    public void SimpleMultilineEditing()
    {
        Console.WriteLine("This is a line of code!");
        Console.WriteLine("This is a line of code!");
        Console.WriteLine("This is a line of code!");
        Console.WriteLine("This is a line of code!");
    }

    public void SelectingSymbols()
    {
        string thisIsABadName = "wow so bad!";
        Console.WriteLine(thisIsABadName);
    }

    public void SelectingSymbolsWithArgs(string thisIsABadName)
    {
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
        Console.WriteLine(thisIsABadName);
    }

    public void SelectingSymbolsWithArgs()
    {
        string thisIsaMEANString = "some string";
        int thisIsaMEANInt = 0;
        float thisIsaMEANFloat = 0.0f;
        double thisIsaMEANDouble = 0.0;

        Console.WriteLine(thisIsaMEANString);
        Console.WriteLine(thisIsaMEANInt);
        Console.WriteLine(thisIsaMEANFloat);
        Console.WriteLine(thisIsaMEANDouble);
    }

    public void SelectMoreOrLess()
    {
        bool thisIsABool = true;
        if(thisIsABool)
        {
            for(int i = 0 ; i < 10; i++)
            {
                SelectingSymbolsWithArgs("This is an argument!");
            }
        }
    }

}