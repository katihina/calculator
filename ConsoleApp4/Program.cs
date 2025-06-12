namespace ConsoleApp4;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Приложение калькулятор");
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Сложить: {Add(a, b)}");
        Console.WriteLine($"Вычитание: {Subtract(a, b)}");
        Console.WriteLine($"Умножение: {Multiply(a, b)}");
        Console.WriteLine($"Деление: {Divide(a, b)}");
    }
    
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static double Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return (double)a / b;
    }
}