using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir string ve bir index giriniz (aralarında virgül ile): ");
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input) && input.Contains(","))
        {
            string[] parts = input.Split(',');
            string text = parts[0];
            int index;

            if (int.TryParse(parts[1], out index))
            {
                if (index >= 0 && index < text.Length)
                {
                    string result = text.Remove(index, 1);
                    Console.WriteLine("Sonuç: " + result);
                }
                else
                {
                    Console.WriteLine("Hata: Girilen index stringin uzunluğunu aşıyor.");
                }
            }
            else
            {
                Console.WriteLine("Hata: Geçerli bir sayı giriniz.");
            }
        }
        else
        {
            Console.WriteLine("Hata: Giriş formatı hatalı. Lütfen string ve sayıyı aralarında virgül olacak şekilde giriniz.");
        }
    }
}
