// Liskov's Substitution principle
// Child classes must be substitutable for their parent class

//class Program
//{
//  public static void Main(string[] args)
//  {
//    IShape circle = new Circle(5);
//    IShape rectangle = new Rectangle(3, 4);

//    CalculateArea(circle);
//    CalculateArea(rectangle);
//  }

//  private static void CalculateArea(IShape circle)
//  {
//    Console.WriteLine(circle.CalculateArea());
//  }
//}

//public interface IShape
//{
//  double CalculateArea();
//}

//public class Circle : IShape
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

//public class Rectangle : IShape
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

//public class Square : Rectangle
//{
//  public Square(double length, double width) : base(length, width)
//  {

//  }
//}

//public class Printer
//{
//  public void Print(IShape shape)
//  {
//    Console.WriteLine(shape);
//  }
//}

//The Square class is not substutable for the parent class
//Because we can override the CalculateArea method but the fields length, width are publicly accessible property

class Program
{
  public static void Main(string[] args)
  {
    IShape circle = new Circle(5);
    IShape rectangle = new Rectangle(3, 4);
    IShape square = new Square(5);

    CalculateArea(circle);
    CalculateArea(rectangle);
    CalculateArea(square);
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

public class Square : IShape
{
  public double Side { get; set; }

  public Square(double side)
  {
    Side = side;
  }

  public double CalculateArea()
  {
    double area = Side * Side;
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

