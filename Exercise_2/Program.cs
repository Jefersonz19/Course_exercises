//Exercise 2
class Program
{

    static void Main()
    {

        Console.WriteLine("Ingrese el primer número ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número ");
        double b = double.Parse(Console.ReadLine());
        
        if (a > b)
        {
            Console.WriteLine($"Resultado: {a*2}");
        }
        else
        {
            Console.WriteLine($"Resultado: {b*3}");
        }
    }
}