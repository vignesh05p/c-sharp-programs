using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the number of rows from the user
        Console.Write("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());
        // Declare a two dimensional array to store the Pascal Triangle
        int[,] pascal = new int[n, n];


      
        // Loop through the rows
        for (int i = 0; i < n; i++)
        {
            // Loop through the columns
            for (int j = 0; j <= i; j++)
            {
                // The first and last element of each row is 1
                if (j == 0 || j == i)
                {
                    pascal[i, j] = 1;
                }
                // The other elements are the sum of the two elements above it
                else
                {
                    pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
                }
            }
        }

        // Loop through the rows to print the Pascal Triangle
        for (int i = 0; i < n; i++)
        {
            // Print some spaces for alignment
            for (int k = 0; k < n - i - 1; k++)
            {
                Console.Write(" ");
            }
            // Print the elements of the current row
            for (int j = 0; j <= i; j++)
            {
                Console.Write(pascal[i, j] + " ");
            }
            // Print a new line
            Console.WriteLine();
        }
    }
}
