using System;
using System.Collections.Generic;

namespace HRManagementSystem
{
    // Base class
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract void Work();
    }

    // Derived class for Manager
    public class Manager : Employee
    {
        public Manager(string name, int id) : base(name, id) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} (ID: {Id}) is managing the team.");
        }
    }

    // Derived class for Developer
    public class Developer : Employee
    {
        public Developer(string name, int id) : base(name, id) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} (ID: {Id}) is writing code.");
        }
    }

    // Derived class for Designer
    public class Designer : Employee
    {
        public Designer(string name, int id) : base(name, id) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} (ID: {Id}) is designing the user interface.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Manager("Alice", 1),
                new Developer("Bob", 2),
                new Designer("Charlie", 3)
            };

            foreach (var employee in employees)
            {
                employee.Work();
            }
        }
    }
}