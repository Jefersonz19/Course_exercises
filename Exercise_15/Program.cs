// Exercise 15

public class InRange
{
    public static void MainInRange() {

    Console.WriteLine("Ingrese un numero: ");
    double number = double.Parse(Console.ReadLine());

    if (number < 10 || number > 20) {
         Console.WriteLine("Resultado: Fuera del rango ");
       } else {
        Console.WriteLine("Resultado: Está en el rango ");
       }
    }
}