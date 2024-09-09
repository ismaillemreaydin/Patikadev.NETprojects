using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen sayıları boşlukla ayırarak giriniz: ");
        string input = Console.ReadLine();
        
        // Girilen sayıları boşluklardan ayır ve integer array'e çevir
        string[] numbers = input.Split(' ');
        int[] nums = Array.ConvertAll(numbers, int.Parse);

        for (int i = 0; i < nums.Length; i += 2)
        {
            int first = nums[i];
            int second = nums[i + 1];
            int sum = first + second;
            
            if (first != second)
            {
                Console.Write(sum + " ");
            }
            else
            {
                Console.Write((sum * sum) + " ");
            }
        }
    }
}
