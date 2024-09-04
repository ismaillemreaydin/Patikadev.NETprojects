using System;

namespace TriangleApp
{
    // Kullanıcıdan veri alma ve doğrulama işlemlerini üstlenir.
    public static class InputHandler
    {
        public static int GetSizeInput()
        {
            Console.Write("Üçgenin boyutunu giriniz: ");
            string input = Console.ReadLine();
            int size;

            while (!int.TryParse(input, out size) || size <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                input = Console.ReadLine();
            }

            return size;
        }
    }

    // Üçgen çiziminden sorumlu sınıf.
    public class TriangleDrawer
    {
        private int _size;

        public TriangleDrawer(int size)
        {
            _size = size;
        }

        public void DrawTriangle()
        {
            for (int i = 1; i <= _size; i++)
            {
                PrintLine(i);
            }
        }

        private void PrintLine(int lineLength)
        {
            string line = new string('*', lineLength);
            Console.WriteLine(line);
        }
    }

    // Programın giriş noktası
    public class Program
    {
        static void Main(string[] args)
        {
            int size = InputHandler.GetSizeInput();
            TriangleDrawer triangleDrawer = new TriangleDrawer(size);
            triangleDrawer.DrawTriangle();
        }
    }
}
