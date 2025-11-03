using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Numbers from 1 to 10 using for loop: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        Console.Write("Numbers from 1 to 10 using foreach loop: ");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine("\n");

        string input;
        do
        {
            Console.Write("Enter a number to find its factorial (or type 'exit' to stop): ");
            input = Console.ReadLine();
            if (input.ToLower() != "exit")
            {
                if (int.TryParse(input, out int num))
                {
                    int fact = Factorial(num);
                    Console.WriteLine($"Factorial of {num} is {fact}\n");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n");
                }
            }

        } while (input.ToLower() != "exit");
        Console.WriteLine("Program ended. Goodbye!");
    }
    static int Factorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}
