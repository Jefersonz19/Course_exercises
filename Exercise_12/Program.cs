//Exercise 12
public class Smallest

{
    public static void MainSmallest() {
 
    int n=5;
    int [] numbers = new int [n];

    for (int i=0; i<n; i++){
        Console.WriteLine($"Ingrese el numero {i+1} : ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    
    }

    int nsmallest = Findnumber(numbers);

    Console.WriteLine($"Resultado: {nsmallest} ");

}

public static int Findnumber(int [] numbers){
    int min = numbers[0];

    for (int i=0; i<numbers.Length; i++){
        if (numbers[i]<min) {
            min = numbers[i];
        }
     }
   
    return min;
}

}