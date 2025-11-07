using System;

class Program
{
    static void Main()
    {
        int a = 3;
        int b = a++;
        Console.WriteLine($"a is {+a++}, b is {-++b}");
        int c = 3;
        int d = ++c;
        Console.WriteLine($"c is {-c--}, d is {~d}");
    }
}
