10. Develop a C# program to create a class named shape. Create three sub classes namely: circle, triangle
and square, each class has two member functions named draw () and erase (). Demonstrate
polymorphism concepts by developing suitable methods, defining member data and main program.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_program_10
{
class Shape
{
public virtual void draw()
{
Console.WriteLine(&quot;Drawing a shape&quot;);
}
public virtual void erase()
{
Console.WriteLine(&quot;Erasing a shape&quot;);
}
}
class Circle : Shape
{

public override void draw()
{
Console.WriteLine(&quot;Drawing a circle&quot;);
}
public override void erase()
{
Console.WriteLine(&quot;Erasing a circle&quot;);
}
}
class Triangle : Shape
{
public override void draw()
{
Console.WriteLine(&quot;Drawing a triangle&quot;);
}
public override void erase()
{
Console.WriteLine(&quot;Erasing a triangle&quot;);
}
}
class Square : Shape
{
public override void draw()
{
Console.WriteLine(&quot;Drawing a square&quot;);
}
public override void erase()
{
Console.WriteLine(&quot;Erasing a square&quot;);
}
}
class Program
{
static void Main(string[] args)
{
Shape[] shapes = new Shape[3];
shapes[0] = new Circle();
shapes[1] = new Triangle();
shapes[2] = new Square();
foreach (Shape shape in shapes)
{
shape.draw();
shape.erase();
}
Console.ReadKey();
}
}
}