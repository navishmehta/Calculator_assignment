using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator using C#");

        Console.WriteLine("Enter the first number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;
        bool isValid = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    isValid = false;
                }
                else
                {
                    result = num1 / num2;
                }
                break;

            default:
                Console.WriteLine("Invalid operation");
                isValid = false;
                break;
        }

        if (isValid)
            Console.WriteLine("The result is: {0}", result);
    }
}