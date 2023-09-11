// Exercise 15

class InRange
{
    static void Main() {

    Console.WriteLine("Ingrese un numero: ");
    double number = double.Parse(Console.ReadLine());

    if (number < 10 || number > 20) {
         Console.WriteLine("Resultado: Fuera del rango ");
       } else {
        Console.WriteLine("Resultado: Está en el rango ");
       }
    }
}