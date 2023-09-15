using System;

public static class Menu
{
    public static void Main(string[] args){
        while(true){
            Console.WriteLine(" Seleccione un programa dentro del Menú de opciones ");
            Console.WriteLine("       Menú      ");
            Console.WriteLine("1. Power");
            Console.WriteLine("2. Double_or_Triple");
            Console.WriteLine("3. Root_or_Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. WeekDay");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");

            int op = Convert.ToInt32(Console.ReadLine());

            switch(op){
                case 1:
                     Power.MainPower();
                break;

                case 2:
                      DoubleTriple.MainDoubleTriple();
                break;

                case 3:
                      RootSquare.MainRootSquare();
                break;

                case 4:
                      Circle.MainCircle();
                break;

                
                case 5:
                      WeekDay.MainWeekDay();
                break;

                
                case 6:
                      Salary.MainSalary();
                break;

                
                case 7:
                      Remainder.MainRemainder();
                break;

                
                case 8:
                      Sum_Evens.MainSum_Evens();
                break;

                
                case 9:
                      Fractions.MainFractions();
                break;

                
                case 10:
                      StringLength.MainStringLength();
                break;

                
                case 11:
                      Average.MainAverage();
                break;

                
                case 12:
                      Smallest.MainSmallest();
                break;

                
                case 13:
                      VowelCounter.MainVowelCounter();
                break;

                
                case 14:
                      Factorial.MainFactorial();
                break;

                
                case 15:
                      InRange.MainInRange();
                break;

                default:
                Console.WriteLine("Opcion no válida ");
                break;
            }
        }
    }
}