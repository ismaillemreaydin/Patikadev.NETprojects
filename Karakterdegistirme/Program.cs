using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan giriş al
        Console.WriteLine("Bir string ifade girin:");
        string input = Console.ReadLine();

        // Stringi boşluklara göre ayır
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length > 1)
            {
                // İlk ve son karakteri al
                char firstChar = word[0];
                char lastChar = word[word.Length - 1];

                // Orta kısmı al
                string middle = word.Substring(1, word.Length - 2);

                // Yeni kelimeyi oluştur
                string swappedWord = lastChar + middle + firstChar;

                // Yeni kelimeyi yazdır
                Console.Write(swappedWord + " ");
            }
            else
            {
                // Tek karakterli kelimeyi olduğu gibi yazdır
                Console.Write(word + " ");
            }
        }

        Console.WriteLine(); // Sonuçları yazdırdıktan sonra yeni bir satır ekle
    }
}

