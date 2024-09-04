using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan girdi alınır
        Console.WriteLine("Bir string ifade giriniz:");
        string input = Console.ReadLine();
        
        // Girilen ifadeyi işleyip çıktıyı üretir
        string result = SwapCharacters(input);
        
        // Sonucu ekrana yazdırır
        Console.WriteLine("Çıktı:");
        Console.WriteLine(result);
    }
    
    static string SwapCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] chars = input.ToCharArray();

        for (int i = 1; i < chars.Length; i += 2)
        {
            // Karakterleri yer değiştirir
            char temp = chars[i];
            chars[i] = chars[i - 1];
            chars[i - 1] = temp;
        }

        return new string(chars);
    }
}
