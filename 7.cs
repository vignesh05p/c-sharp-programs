using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_program6
{
    internal class Program
    {
        static void Main(string[] args)
        {

                string sourceFilePath = "D:\\madhvavadiraja_2023_odd\\c#\\programs\\lab_program6\\source.txt";
                string destinationFilePath = "D:\\madhvavadiraja_2023_odd\\c#\\programs\\lab_program6\\destination.txt";

                try
                {
                    string fileContents = File.ReadAllText(sourceFilePath);

                    File.WriteAllText(destinationFilePath, fileContents);

                    Console.WriteLine("File copied successfully!");
                Console.ReadKey();
                }
          
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
            }
        }
    }

