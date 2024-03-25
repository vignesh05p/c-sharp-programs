
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        while (a == 1)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
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
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
System.Environment.Exit(0);
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
            Console.Write("If you want to continue enter 1 else enter o");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
}

