using System;
using System.Globalization;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // int zig;
        // do
        // {
        //     int x = 5;
        //     int y = 8;
        //     zig = x * y;
        // } while (zig >= 45);
        // {
        //     Console.WriteLine("You are doing great");
        // }
        // string response;
        // do 
        //     {
        //         Console.Write("Dou want to continue: ");
        //         response = Console.ReadLine();
        //     } while (response == "yes");
        // for (int i = 0; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        // for (int i = 0; i<=20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }
        // Random randomGenerator = new Random();
        // int number = randomGenerator .Next(1, 11);


        Console.WriteLine("Enter magic numberjBetween 1 and 11");        
        Random randomGenerator = new Random();
        int number = randomGenerator .Next(1, 11);
        int guessMagic = 0;
        while (guessMagic != number)
        {
            Console.Write("Enter your guess: ");
            guessMagic = Convert.ToInt32(Console.ReadLine());

            if (guessMagic > number)
                {
                    Console.WriteLine("Lower");
                }
            else
                {
                    Console.WriteLine("higher");
                }
        }
        Console.WriteLine($"The Guess {number} is correct");
        
    }   
}