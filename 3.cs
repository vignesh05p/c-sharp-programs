class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.WriteLine("All substrings of the given string are:");
        for (int i = 0; i < inputString.Length; i++)
        {
            for (int j = i + 1; j <= inputString.Length; j++)
            {
                Console.WriteLine(inputString.Substring(i, j - i));
            }
        }
    }
}
