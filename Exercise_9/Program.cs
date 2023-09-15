// Exercise 9
public class Fractions
{
    public static void MainFractions()
    {

        Console.WriteLine("Ingrese la primera fraccion(en formato a/b): ");
        string frac1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda fraccion(en formato a/b): ");
        string frac2 = Console.ReadLine();
        
        if (TryParseFraction(frac1, out int a1, out int b1) && TryParseFraction(frac2, out int a2, out int b2))
        {
            int op_denom = b1*b2;
            int op_num = (a1*b2) - (a2*b1);

            Console.WriteLine($"Resultado: {op_num}/{op_denom}");
        }
        else {
            Console.WriteLine("Entrada no válida");
        }

    }

    static bool TryParseFraction(string frac, out int numerat, out int denomin){
        numerat = 0;
        denomin = 1;

        string [] spliter = frac.Split('/');

        if (spliter.Length != 2)
        {
            return false;
        }
        
        if (int.TryParse(spliter[0], out int a) && int.TryParse(spliter[1], out int b)){
            if (b !=0 ){
                numerat = a;
                denomin = b;
                return true; 
            }
        } 

        return false;
    }
}