11. Develop a C# program to create an abstract class Shape with abstract methods calculateArea() and
calculatePerimeter(). Create subclasses Circle and Triangle that extend the Shape class and implement the
respective methods to calculate the area and perimeter of each shape.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_program_11
{
abstract class Shape
{
public abstract double calculateArea();
public abstract double calculatePerimeter();
}
class Circle : Shape
{
private double radius;
public Circle(double radius)
{
this.radius = radius;
}
public override double calculateArea()
{
return Math.PI * radius * radius;
}
public override double calculatePerimeter()
{
return 2 * Math.PI * radius;
}
}
class Triangle : Shape
{
private double side1;
private double side2;
private double side3;
public Triangle(double side1, double side2, double side3)
{
this.side1 = side1;
this.side2 = side2;
this.side3 = side3;
}
public override double calculateArea()
{
double s = (side1 + side2 + side3) / 2;
return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
}
public override double calculatePerimeter()
{
return side1 + side2 + side3;
}
}
public class ShapeClient

{
public static void Main(string[] args)
{
double side1 = 13, side2 = 9, side3=10;
Shape triangle = new Triangle(side1, side2,side3);
Console.WriteLine(&quot;The sides of circle are side1:&quot;+side1+&quot; side2:&quot;+side2+&quot; side3:&quot;+side3+
&quot;\nThe area of the triangle is: &quot; + triangle.calculateArea()
+ &quot;\nThe perimeter of the triangle is: &quot; + triangle.calculatePerimeter() + &quot;.&quot;);
double radius = 3;
Shape circle = new Circle(radius);
Console.WriteLine(&quot;\nThe radius of the circle is: &quot; + radius
+ &quot;\nThe area of the circle is: &quot; + circle.calculateArea()
+ &quot;\nThe perimeter of the circle is: &quot; + circle.calculatePerimeter() + &quot;.&quot;);
Console.ReadKey();
}
}
}