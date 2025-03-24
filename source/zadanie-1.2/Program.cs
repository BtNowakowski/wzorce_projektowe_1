using System;

namespace VehiclesApp
{
    class Vehicles
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Id { get; set; }
        public double Mileage { get; set; }
        public int Years { get; set; }

        public void Read()
        {
            Console.Write("Enter vehicle name: ");
            Name = Console.ReadLine();
            Console.Write("Enter manufacturer: ");
            Manufacturer = Console.ReadLine();
            Console.Write("Enter ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter mileage: ");
            Mileage = double.Parse(Console.ReadLine());
            Console.Write("Enter years: ");
            Years = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"Vehicle Name: {Name}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Years: {Years}");
        }
    }

    class Cars : Vehicles
    {
        public string Engine { get; set; }
        public string Color { get; set; }

        public void Read1()
        {
            Read();
            Console.Write("Enter engine type: ");
            Engine = Console.ReadLine();
            Console.Write("Enter color: ");
            Color = Console.ReadLine();
        }

        public void Show1()
        {
            Show();
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.Read1();
            car.Show1();
        }
    }
}