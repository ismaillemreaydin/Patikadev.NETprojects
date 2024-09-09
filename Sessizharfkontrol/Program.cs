using System;

class Program
{
    static void Main()
    {
        // Örnek input stringler
        string[] inputs = { "Merhaba Umut Arya", "Example Text", "Hello World" };

        // Her bir input string için kontrol yap
        foreach (var input in inputs)
        {
            Console.WriteLine(HasAdjacentConsonants(input));
        }
    }

    static bool HasAdjacentConsonants(string input)
    {
        // Küçük harfe dönüştür
        input = input.ToLower();

        // Sessiz harfler (alfabede sessiz olanlar)
        char[] consonants = "bcdfghjklmnpqrstvwxyz".ToCharArray();

        // Input string üzerinde geçiş yap
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (Array.Exists(consonants, c => c == input[i]) &&
                Array.Exists(consonants, c => c == input[i + 1]))
            {
                return true;
            }
        }

        return false;
    }
}
