//Exercise 1
class Program
{

    static void Main()
    {

        Console.WriteLine("Ingrese un número ");
        double a = double.Parse(Console.ReadLine());
        
        if (a > 0)
        {
            a = Math.Pow(a, 2);
            Console.WriteLine($"Resultado: El número elevado al cuadrado es: {a}");
        }
        else if (a < 0)
        {
            Console.WriteLine("Resultado: Numero negativo");
        }
        else
        {
            Console.WriteLine("Resultado: 0");
        }
    }
}