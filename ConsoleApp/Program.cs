// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        PrintLine();
        ReadAndWrite();
    }

    static void PrintLine()
    {
        Console.WriteLine("Hello World");
    }

    static void ReadAndWrite()
    {
        Console.WriteLine("Enter Your Name");
        string FirstName = Console.ReadLine();
        string LastName = Console.ReadLine();
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
    }
}