// Aiden McLeod
// ICS2O-Unit5-02-CSharp
// May 2 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int integer;

        Console.Write("Enter an integer: ");
        integer = Convert.ToInt32(Console.ReadLine());
        if (integer >= 0)
        {
            Console.Write(integer + " is a positive integer.");
        }
        else
        {
            Console.Write(integer + " is a negative integer.");
        }
        Console.WriteLine("\nFinished.");
    }
}