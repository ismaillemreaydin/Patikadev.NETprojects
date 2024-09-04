using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Fibonacci serisi için derinlik giriniz: ");
        int depth = int.Parse(Console.ReadLine());

        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        List<int> fibonacciSeries = fibonacciCalculator.GenerateFibonacciSeries(depth);

        AverageCalculator averageCalculator = new AverageCalculator();
        double average = averageCalculator.CalculateAverage(fibonacciSeries);

        Console.WriteLine($"Fibonacci serisinin ortalaması: {average}");
    }
}

public class FibonacciCalculator
{
    public List<int> GenerateFibonacciSeries(int depth)
    {
        List<int> series = new List<int>();
        if (depth > 0) series.Add(0);
        if (depth > 1) series.Add(1);
        
        for (int i = 2; i < depth; i++)
        {
            series.Add(series[i - 1] + series[i - 2]);
        }

        return series;
    }
}

public class AverageCalculator
{
    public double CalculateAverage(List<int> numbers)
    {
        int sum = numbers.Sum();
        return (double)sum / numbers.Count;
    }
}
