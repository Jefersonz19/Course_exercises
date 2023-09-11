// Exercise 14

class Factorial
{
    static void Main() {

    Console.WriteLine("Ingrese un número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >=0 ){

        double factorial = Calculate(num);
        Console.WriteLine($"Resultado: {factorial} ");
     }  else {
        Console.WriteLine($"El factorial no puede ser calculado ");
        }
    }

    static double Calculate(int num){
        if (num == 0){
            return 1;
        }

        double factorial = 1;
        for (int i=1; i<=num; i++) {
            factorial *= i;
        }
        return factorial;
    }
}