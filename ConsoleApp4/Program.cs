namespace ConsoleApp4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Калькулятор");
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Add: {Add(a, b)}");
    }
    
    static int Add(int a, int b) => a + b;
}