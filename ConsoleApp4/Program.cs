namespace ConsoleApp4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator App");
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Subtract: {Subtract(a, b)}");
    }
    
    static int Subtract(int a, int b) => a - b;
}