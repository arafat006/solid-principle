// Single responsibility principle
// A class should do one thing and therefore it should have only a single reason to change

//class Program
//{
//  public static void Main(string[] args)
//  {
//    Circle circle = new Circle(5);
//    CalculateArea(circle);
//    Print(circle);
//  }

//  private static void CalculateArea(Circle circle)
//  {
//    double area = Math.PI * circle.Radius * circle.Radius;
//    Console.WriteLine(area);
//  }
//  private static void Print(Circle circle)
//  {
//    Console.WriteLine(circle);
//  }
//}

//public class Circle
//{
//  public double Radius { get; set; }

//  public Circle(double radius)
//  {
//    Radius = radius;
//  }
//}

//Program class has so many responsibilities. Calculate area, print, etc.
//Function CalculateArea should be in Circle class because it's related to the circle

class Program
{
  public static void Main(string[] args)
  {
    Circle circle = new Circle(5);
    circle.CalculateArea();
    new Printer().Print(circle);
  }
}

public class Circle
{
  public double Radius { get; set; }

  public Circle(double radius)
  {
    Radius = radius;
  }

  public void CalculateArea()
  {
    double area = Math.PI * Radius * Radius;
    Console.WriteLine(area);
  }
}

public class Printer
{
  public void Print(Circle circle)
  {
    Console.WriteLine(circle);
  }
}