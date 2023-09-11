//Exercise 5 

class Week
{
    static void Main() {

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