namespace ConsoleApp4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Приложение калькулятор");
        
        Console.WriteLine($"Деление: {Divide(a, b)}");
    }
    
    static double Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return (double)a / b;
    }
}