//Exercise 1
using System;

public class Power
{
    public static void MainPower()
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

//Exercise 2
public class DoubleTriple
{

    public static void MainDoubleTriple()
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

//Exercise 3
public class RootSquare
{

    public static void MainRootSquare()
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

//Exercise 4

public class Circle
{
    public static void MainCircle(){
        Console.WriteLine("Ingrese el radio de un circulo");
        double r = Convert.ToDouble(Console.ReadLine());
        double Perimeter = 2*System.Math.PI * r;
        Console.WriteLine($"The perimeter is: {Perimeter}");
    }

}

//Exercise 5 

public class WeekDay
{
    public static void MainWeekDay() {

    int n;
    do {
    Console.WriteLine("Ingrese un número del 1 al 7");
    n = Convert.ToInt32(Console.ReadLine());

    }  while (n < 1     || n >7 );
    
    
    string dia = " ";

    switch(n){
        case 1:
        dia = "Lunes";
        break;

        case 2:
        dia = "Martes";
        break;

        case 3:
        dia = "Miercoles";
        break;

        case 4:
        dia = "Jueves";
        break;

        case 5:
        dia = "Viernes";
        break;

        default:
        dia = "Numero fuera del rango laboral";
        break;
    }

     Console.WriteLine($"Resultado: {dia}");
    }

}

//Exercise 6

public class Salary
{
    public static void MainSalary() {

    Console.WriteLine("Ingrese su salario anual ");
    double salary = double.Parse(Console.ReadLine());
    double spare=0;

    if (salary > 12000)
        {
            salary = salary-12000;
            spare = salary*0.15;
            Console.WriteLine($"Resultado: {spare}");
        }
        else {
             Console.WriteLine("Resultado: No debe Impuestos ");
        }
    }

}

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


// Exercise 8
public class Sum_Evens
{
    public static void MainSum_Evens() {

    int sum=0;

    for (int i=0; i<51; i++){

        if (i % 2==0){
            sum += i;
        }
    }

    Console.WriteLine($"Resultado: {sum}");

 }
    
}

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


//Exercise 10
public class StringLength
{
    public static void MainStringLength() {

    Console.WriteLine("Ingrese una palabra ");
    string word = Console.ReadLine();
    Console.WriteLine($"Ingrese una palabra: {word.Length}");
   }
}

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

// Exercise 13

public class VowelCounter
{
    public static void MainVowelCounter() {

    Console.WriteLine("Ingrese una palabra: ");
    string word  = Console.ReadLine();

    int vowels = CountVowels(word);

    Console.WriteLine($"Resultado: {vowels}");

    static int CountVowels (string word) {
        int cont = 0;
        word = word.ToLower();

        foreach(char leter in word)
        {
            if (IsVowel(leter)){
                cont ++;
            }
        } return cont;
    }

    static bool IsVowel(char leter){
          return "aeiou".Contains(leter);
       }

    }
}

// Exercise 14

public class Factorial
{
    public static void MainFactorial() {

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