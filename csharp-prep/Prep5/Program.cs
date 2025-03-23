using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {

    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static void PrompUserName()
    {
        Console.Write("Enter Your Username: ");
        string userName = Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter Your Favorite Number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }
    

}

