namespace ConsoleApp4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator App");
        
        Console.WriteLine($"Умножение: {Multiply(a, b)}");
    }
    
    static int Multiply(int a, int b) => a * b;
}