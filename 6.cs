class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] triangle = new int[rows][];
        int counter = 1;




      
        // Loop through the rows of the jagged array
        for (int i = 0; i < rows; i++)
        {
            // Initialize the ith row with an array of size i+1
            triangle[i] = new int[i + 1];

            // Loop through the columns of the ith row
            for (int j = 0; j < i + 1; j++)
            {
                // Assign the counter value to the current element
                triangle[i][j] = counter;
                counter++;
            }
        }


      
        // Print the jagged array as Floyd's Triangle
        Console.WriteLine("Floyd's Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(triangle[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}


