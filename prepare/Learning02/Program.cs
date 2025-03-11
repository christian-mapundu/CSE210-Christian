using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        int age;
        age = 24;
        Console.Write("What is your first name: ");
        string fname = Console.ReadLine();

        if(age >= 24 && fname == "Christian")
        {
            System.Console.WriteLine("You are old enough to make decisions on your own");  
        } else
        {
            System.Console.WriteLine("You should come back when your age and name are verified");
            byte b = 30;
            Console.Write($"your byte number is {b}");
            var number = 234;
            byte c = Convert.ToByte(number);
            System.Console.Write(c);
        }
    }
}