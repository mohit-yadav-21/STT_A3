using System;
class Calculator
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    // Constructor
    public Calculator(double num1, double num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    public double Add() => Num1 + Num2;
    public double Subtract() => Num1 - Num2;
    public double Multiply() => Num1 * Num2;
    public double Divide() => Num2 != 0 ? Num1 / Num2 : double.NaN; 
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Basic Calculator ===\n");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Calculator calc = new Calculator(num1, num2);

        double sum = calc.Add();
        double difference = calc.Subtract();
        double product = calc.Multiply();
        double quotient = calc.Divide();

        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");

        if (sum % 2 == 0)
            Console.WriteLine("The sum is even.");
        else
            Console.WriteLine("The sum is odd.");

        Console.WriteLine("\n=== Program Finished ===");
    }
}
