
using System;

class Calculator {
    static void Main() {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();
        
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double result = 0;
        if (op == "+") result = a + b;
        else if (op == "-") result = a - b;
        else if (op == "*") result = a * b;
        else if (op == "/") result = a / b;
        else {
            Console.WriteLine("Invalid operator!");
            return;
        }
        
        Console.WriteLine($"Result: {result}");
    }
}
