using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen n tane sayı giriniz (aralarına boşluk bırakın):");
        var input = Console.ReadLine();
        var numbers = input.Split(' ').Select(int.Parse).ToList();

        int sumOfDifferences = 0;
        int sumOfSquaredAbsDifferences = 0;

        var lessThan67 = numbers.Where(n => n < 67).ToList();
        var greaterThan67 = numbers.Where(n => n > 67).ToList();

        // Küçük olanların farklarının toplamı
        if (lessThan67.Count > 1)
        {
            for (int i = 0; i < lessThan67.Count; i++)
            {
                for (int j = i + 1; j < lessThan67.Count; j++)
                {
                    sumOfDifferences += Math.Abs(lessThan67[i] - lessThan67[j]);
                }
            }
        }

        // Büyük olanların farklarının mutlak karelerinin toplamı
        if (greaterThan67.Count > 1)
        {
            for (int i = 0; i < greaterThan67.Count; i++)
            {
                for (int j = i + 1; j < greaterThan67.Count; j++)
                {
                    int difference = greaterThan67[i] - greaterThan67[j];
                    sumOfSquaredAbsDifferences += difference * difference;
                }
            }
        }

        Console.WriteLine($"{sumOfDifferences} {sumOfSquaredAbsDifferences}");
    }
}

