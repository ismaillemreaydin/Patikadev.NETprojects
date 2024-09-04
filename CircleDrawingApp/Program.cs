using System;

namespace CircleDrawingApp
{
    public class CircleDrawer
    {
        private const char DrawChar = '*';

        public void DrawCircle(int radius)
        {
            double thickness = 0.4;
            double rIn = radius - thickness;
            double rOut = radius + thickness;

            for (int y = radius; y >= -radius; --y)
            {
                for (int x = -radius; x < rOut; x += 2)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(DrawChar);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public class ConsoleReader
    {
        public int GetRadiusFromUser()
        {
            Console.Write("Lütfen dairenin yarıçapını giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int radius) && radius > 0)
            {
                return radius;
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen pozitif bir tam sayı giriniz.");
                return GetRadiusFromUser();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var consoleReader = new ConsoleReader();
            int radius = consoleReader.GetRadiusFromUser();

            var circleDrawer = new CircleDrawer();
            circleDrawer.DrawCircle(radius);
        }
    }
}
