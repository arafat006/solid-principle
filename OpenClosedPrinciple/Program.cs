// Open-Closed principle
// A class should be open for extension but closed to modification

//class Program
//{
//  public static void Main(string[] args)
//  {
//    Circle circle = new Circle(5);
//    Rectangle rectangle = new Rectangle(3, 4);

//    CalculateArea(circle);
//    CalculateArea(rectangle);
//  }

//  private static void CalculateArea(Circle circle)
//  {
//    Console.WriteLine(circle.CalculateArea());
//  }

//  // Newly added for rectangle
//  private static void CalculateArea(Rectangle rectangle)
//  {
//    Console.WriteLine(rectangle.CalculateArea());
//  }
//}

//public class Circle
//{
//  public double Radius { get; set; }

//  public Circle(double radius)
//  {
//    Radius = radius;
//  }

//  public double CalculateArea()
//  {
//    double area = Math.PI * Radius * Radius;
//    return area;
//  }
//}

//public class Rectangle
//{
//  public double Length { get; set; }
//  public double Width { get; set; }

//  public Rectangle(double length, double width)
//  {
//    Length = length;
//    Width = width;
//  }

//  public double CalculateArea()
//  {
//    double area = Length * Width;
//    return area;
//  }
//}

//public class Printer
//{
//  public void Print(Circle circle)
//  {
//    Console.WriteLine(circle);
//  }
//  // Newly added for rectangle
//  public void Print(Rectangle rectangle)
//  {
//    Console.WriteLine(rectangle);
//  }
//}

//Each time needs to create a new function for new Class
//We can use an interface to overcome this modification issue

class Program
{
  public static void Main(string[] args)
  {
    IShape circle = new Circle(5);
    IShape rectangle = new Rectangle(3, 4);

    CalculateArea(circle);
    CalculateArea(rectangle);
  }

  private static void CalculateArea(IShape circle)
  {
    Console.WriteLine(circle.CalculateArea());
  }
}

public interface IShape
{
  double CalculateArea();
}

public class Circle : IShape
{
  public double Radius { get; set; }

  public Circle(double radius)
  {
    Radius = radius;
  }

  public double CalculateArea()
  {
    double area = Math.PI * Radius * Radius;
    return area;
  }
}

public class Rectangle : IShape
{
  public double Length { get; set; }
  public double Width { get; set; }

  public Rectangle(double length, double width)
  {
    Length = length;
    Width = width;
  }

  public double CalculateArea()
  {
    double area = Length * Width;
    return area;
  }
}

public class Printer
{
  public void Print(IShape shape)
  {
    Console.WriteLine(shape);
  }
}

//Now this is extendable because we can add new shapes without any modification