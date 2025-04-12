using System;

class Program
{
    static void Main(string[] args)
    {
        // Calculator
        Console.Write("Enter the first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        switch (op)
        {
            case '+':
                Console.WriteLine($"{a} {op} {b} = {a + b}");
                break;
            case '-':
                Console.WriteLine($"{a} {op} {b} = {a - b}");
                break;
            case '*':
                Console.WriteLine($"{a} {op} {b} = {a * b}");
                break;
            case '/':
                if (b == 0) {
                    Console.WriteLine("You can't divide by 0!");
                } else {
                    Console.WriteLine($"{a} {op} {b} = {a / b}");
                }
                break;
            default:
                Console.WriteLine("Invalid operator entered!");
                break;
        }
        
        // Multiplication Table
        Console.Write("Which multiplication table would you like to see? ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 9; i++) {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}