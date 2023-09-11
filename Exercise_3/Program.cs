//Exercise 3
class Program
{

    static void Main()
    {

        Console.WriteLine("Ingrese un número ");
        double a = double.Parse(Console.ReadLine());
        
        if (a > 0)
        {
            a = Math.Sqrt(a);
            Console.WriteLine($"Resultado: {a}");
        }
        else
        {
            a = Math.Pow(a,2);
            Console.WriteLine($"Resultado: {a}");
        }
    }
}