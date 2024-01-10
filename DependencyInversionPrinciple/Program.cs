// Dependency Inversion principle
// High level classes should not depend on low-level classes. Both should depend upon abstractions.

//High level class: -> entry point of the program -> orchestrates the execution flow
//class Program
//{
//  public static void Main(string[] args)
//  {
//    IShape circle = new Circle(5);
//    IShape cube = new Cube(5);

//    new Printer().Print(circle);
//    new Printer().Print(cube);
//  }
//}

////Low level classes:
//public interface IShape
//{

//}

//public interface IShape2D : IShape
//{
//  double CalculateArea();
//}

//public interface IShape3D : IShape
//{
//  double CalculateVolume();
//}

//public class Circle : IShape2D
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

//public class Cube : IShape3D
//{
//  public double Side { get; set; }

//  public Cube(double side)
//  {
//    Side = side;
//  }

//  public double CalculateVolume()
//  {
//    double area = Side * Side * Side;
//    return area;
//  }
//}

//public class Printer
//{
//  public void Print(IShape shape)
//  {
//    Console.WriteLine(shape);
//  }
//}

//The Main() function using Printer class to print the instance class name
//The Main() function directly depends on the Printer class with tight coupling
//We can introduce new interface for the Printer class so that only Class can be changed as needed
//without changing the print() method


//High level class: -> entry point of the program -> orchestrates the execution flow
class Program
{
  public static void Main(string[] args)
  {
    IShape circle = new Circle(5);
    IShape cube = new Cube(5);

    IPrinter printer = new Printer();
    printer.Print(circle);
    printer.Print(cube);
  }
}

//Low level classes:
public interface IShape
{

}

public interface IShape2D : IShape
{
  double CalculateArea();
}

public interface IShape3D : IShape
{
  double CalculateVolume();
}

public class Circle : IShape2D
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

public class Cube : IShape3D
{
  public double Side { get; set; }

  public Cube(double side)
  {
    Side = side;
  }

  public double CalculateVolume()
  {
    double area = Side * Side * Side;
    return area;
  }
}

public interface IPrinter
{
  void Print(IShape shape);
}

public class Printer : IPrinter
{
  public void Print(IShape shape)
  {
    Console.WriteLine(shape);
  }
}