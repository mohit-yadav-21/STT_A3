using System;

class Program
{
   static void Main(string[] args)
   {
       Console.WriteLine("=== Welcome to My First .NET App ===\n");

       Console.Write("Enter your name: ");
       string name = Console.ReadLine();

       Console.Write("Enter your age: ");
       int age = Convert.ToInt32(Console.ReadLine());

       int nextYearAge = age + 1;

       Console.WriteLine($"\nHello {name}!");
       Console.WriteLine($"You are {age} years old now.");
       Console.WriteLine($"Next year, you will be {nextYearAge} years old.");

       if (age < 18)
       {
           Console.WriteLine("You're a minor.");
       }
       else if (age < 60)
       {
           Console.WriteLine("You're an adult.");
       }
       else
       {
           Console.WriteLine("You're a senior citizen.");
       }

       Console.WriteLine("\nThank you for trying my first C# program!");
   }
}
