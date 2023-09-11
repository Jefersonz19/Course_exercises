//Exercise 5 

class Salary
{
    static void Main() {

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