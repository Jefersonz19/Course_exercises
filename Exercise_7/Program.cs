// Exercise 7
public class Remainder {
    
    public static void MainRemainder() {

    Console.WriteLine("Ingrese el primer numero ");
    double n = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Ingrese el segundo numero ");
    double m = double.Parse(Console.ReadLine());
    double mod = n%m;
    Console.WriteLine($"Resultado: {mod}");

    }
}