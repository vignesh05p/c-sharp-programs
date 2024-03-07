9. Design a class “Complex” with data members,
constructor and method for overloading a binary operator ‘+’.
Develop a C# program to read Two complex number
and Print the results of addition.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_program9
{
public class Complex
{
public int real;
public int imaginary;

public Complex(int real, int imaginary)
{
this.real = real;
this.imaginary = imaginary;
}

public static Complex operator +(Complex c1, Complex c2)
{
return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
}
}

class Program

{
static void Main(string[] args)
{
Console.WriteLine(&quot;Enter the first complex number:&quot;);
Console.Write(&quot;Enter the Real Part: &quot;);
int real1 = Convert.ToInt32(Console.ReadLine());
Console.Write(&quot;Enter the Imaginary Part: &quot;);
int imaginary1 = Convert.ToInt32(Console.ReadLine());
Complex num1 = new Complex(real1, imaginary1);

Console.WriteLine(&quot;Enter the second complex number:&quot;);
Console.Write(&quot;Enter the Real Part: &quot;);
int real2 = Convert.ToInt32(Console.ReadLine());
Console.Write(&quot;Enter the Imaginary Part: &quot;);
int imaginary2 = Convert.ToInt32(Console.ReadLine());
Complex num2 = new Complex(real2, imaginary2);

Console.WriteLine(&quot;\n Entered complex Numbers are as Follows: &quot;);
Console.WriteLine(&quot;Num 1 : {0} + {1}i&quot;, num1.real, num1.imaginary);
Console.WriteLine(&quot;Num 2: {0} + {1}i&quot;, num2.real, num2.imaginary);

Complex sum = num1 + num2;
Console.WriteLine(&quot;The sum of the two complex numbers is: {0} + {1}i&quot;, sum.real,
sum.imaginary);
Console.ReadKey();
}
}
}

Sample Output

Enter the first complex number:
Enter the Real Part: 2
Enter the Imaginary Part: 3

Enter the second complex number:
Enter the Real Part: 4
Enter the Imaginary Part: 2
Entered complex Numbers are as Follows:
Num 1 : 2 + 3i
Num 2: 4 + 2i
The sum of the two complex numbers is: 6 + 5i