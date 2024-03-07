7. Develop a C# program to read a text file and copy the file contents to another text file.
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
string sourceFilePath =
&quot;D:\\madhvavadiraja_2023_odd\\c#\\programs\\lab_program6\\source.txt&quot;;
string destinationFilePath =
&quot;D:\\madhvavadiraja_2023_odd\\c#\\programs\\lab_program6\\destination.txt&quot;;
try
{
// Read the contents of the source file
string fileContents = File.ReadAllText(sourceFilePath);
// Write the contents to the destination file
File.WriteAllText(destinationFilePath, fileContents);
Console.WriteLine(&quot;File copied successfully!&quot;);
Console.ReadKey();
}
catch (Exception ex)
{
Console.WriteLine(&quot;Error: &quot; + ex.Message);
Console.ReadKey();
}
}
}
}