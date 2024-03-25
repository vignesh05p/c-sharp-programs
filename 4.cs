using System;

class Program
{
    static void Main(string[] args)
    {
  
        int[] numbers = { 10, 20, 30, 40, 50 };
        int result = 0;

        
        try
        {
            // Attempt to divide the first element of the array by the user input
            Console.Write("Enter a number to divide by: ");
            int divisor = int.Parse(Console.ReadLine());
            result = numbers[0] / divisor;

            // Attempt to access the sixth element of the array
            Console.WriteLine("The sixth element of the array is: " + numbers[5]);
        }
        // Use a catch block to handle the specific exception
        catch (DivideByZeroException ex)
        {
            // Display the message of the exception
            Console.WriteLine("Division by zero exception: " + ex.Message);
        }
        // Use another catch block to handle another specific exception
        catch (IndexOutOfRangeException ex)
        {
            // Display the message of the exception
            Console.WriteLine("Index out of range exception: " + ex.Message);
        }
        // Use a finally block to execute the code that always runs
        finally
        {
            // Display the result of the division
            Console.WriteLine("The result of the division is: " + result);
        }
    }
}

