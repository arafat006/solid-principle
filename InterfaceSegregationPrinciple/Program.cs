// Interface Segregation principle
// Classes should not forced to implement a function they do not need

class Program
{
  public static void Main(string[] args)
  {
    IShape circle = new Circle(5);

    new Printer().Print(circle);
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

public class Cube : IShape
{
  public double Side { get; set; }

  public Cube(double side)
  {
    Side = side;
  }

  //This method is useless for Cube shape. So that, returning dummy value/0
  public double CalculateArea()
  {
    return 0;
  }
}

public class Printer
{
  public void Print(IShape shape)
  {
    Console.WriteLine(shape);
  }
}


//The method CalculateArea() is useless for Cude.
//We can create another suitable interface for the Cube class with neccesary functionalities


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