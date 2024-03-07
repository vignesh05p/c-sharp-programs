12. Develop a C# program to create an interface Resizable with methods resizeWidth(int width) and
resizeHeight(int height) that allow an object to be resized. Create a class Rectangle that implements the
Resizable interface and implements the resize methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Lab_Program_12
{
interface Resizable
{
int resizeWidth(int width);
int resizeHeight(int height);
}
class Rectangle : Resizable
{
private int width;
private int height;
public Rectangle(int width, int height)
{
this.width = width;
this.height = height;
Console.WriteLine(&quot;Initial width and height of rectangle (&quot;+this.width+&quot;,&quot;+this.height+&quot;)&quot;);
}
public int resizeWidth(int width)
{
this.width = width;
return width;
}
public int resizeHeight(int height)
{
this.height = height;
return height;
}
}
public class ShapeClient
{
public static void Main(string[] args)
{
Rectangle r = new Rectangle(10, 15);
Console.WriteLine(&quot;Resize width of rectangle &quot;+ r.resizeWidth(15));
Console.WriteLine(&quot;Resize height of rectangle &quot;+ r.resizeHeight(20));
Console.ReadKey();
}
}
}