//Exercise 11
public class Average
{
    public static void MainAverage() {

    int n;
    double sum =0;

    for (int i=0; i<4; i++){
    Console.WriteLine($"Ingrese el numero {i+1} : ");
    n = Convert.ToInt32(Console.ReadLine());
    sum += n;
    }
    Console.WriteLine($"Resultado {sum/4}");
   }

}