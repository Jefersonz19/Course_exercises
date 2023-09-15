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