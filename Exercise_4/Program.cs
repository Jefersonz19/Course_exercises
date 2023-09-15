//Exercise 4


//     var  circle1 = new Circle();
//     Console.WriteLine("Ingrese el radio de un circulo");
//     var r = double.Parse(Console.ReadLine());
//     circle1.radius = r;
//     Console.WriteLine($"The perimeter is: {circle1.Perimeter()}");
    
// class Circle
// {
//     public double radius { get; set; }

//     public double Perimeter() => 2*System.Math.PI * radius;
 
// }

public class Circle
{
    public static void MainCircle(){
        Console.WriteLine("Ingrese el radio de un circulo");
        double r = Convert.ToDouble(Console.ReadLine());
        double Perimeter = 2*System.Math.PI * r;
        Console.WriteLine($"The perimeter is: {Perimeter}");
    }

}