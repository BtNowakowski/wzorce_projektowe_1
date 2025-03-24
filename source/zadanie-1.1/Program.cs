using System;

namespace TrapezoidAreaCalculator
{
    class Trapezoid
    {
        private double a, b, h, surface_area;

        public void ReadData()
        {
            Console.Write("Enter the length of side a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height h: ");
            h = Convert.ToDouble(Console.ReadLine());
        }

        public void ProcessData()
        {
            surface_area = ((a + b) / 2) * h;
        }

        public void ShowResults()
        {
            Console.WriteLine($"Side a: {a:F1}");
            Console.WriteLine($"Side b: {b:F1}");
            Console.WriteLine($"Height h: {h}");
            Console.WriteLine($"Surface area: {surface_area:F1}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trapezoid trapezoid = new Trapezoid();
            trapezoid.ReadData();
            trapezoid.ProcessData();
            trapezoid.ShowResults();
        }
    }
}