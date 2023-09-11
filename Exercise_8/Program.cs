class Sum_Evens
{
    static void Main() {

    int sum=0;

    for (int i=0; i<51; i++){

        if (i % 2==0){
            sum += i;
        }
    }

    Console.WriteLine($"Resultado: {sum}");

 }
    
}
    

