using System;
using System.Threading;

namespace Lab10
{
    class ProgramClass
    {
        private int data;
        private static int counter = 0;

        public ProgramClass(int x)
        {
            data = x;
            counter++;
            Console.WriteLine($"Constructor Called. Object count = {counter}");
        }

        ~ProgramClass()
        {
            counter--;
            Console.WriteLine($"Object Destroyed. Remaining objects = {counter}");
        }

        public void set_data(int x) => data = x;

        public void show_data() => Console.WriteLine($"Data = {data}");

        static void Main(string[] args)
        {
            Console.WriteLine("=== Constructors and Data Control ===");
            TestConstructors();

            // Force GC to show destructor output
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Thread.Sleep(1000);

            Console.WriteLine("\n=== Inheritance and Method Overriding ===");
            TestInheritance();


        }

        static void TestConstructors()
        {
            ProgramClass obj1 = new ProgramClass(10);
            ProgramClass obj2 = new ProgramClass(20);
            ProgramClass obj3 = new ProgramClass(30);

            obj1.set_data(10);
            obj2.set_data(20);
            obj3.set_data(30);

            obj1.show_data();
            obj2.show_data();
            obj3.show_data();
        }

        static void TestInheritance()
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Vehicle(80, 100);
            vehicles[1] = new Car(120, 90, 4);
            vehicles[2] = new Truck(60, 150, 2000);

            foreach (var v in vehicles)
            {
                v.Drive();
                v.ShowInfo();
                Console.WriteLine();
            }
        }
    }

    class Vehicle
    {
        protected int speed;
        protected int fuel;

        public Vehicle(int speed, int fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
        }

        public virtual void Drive()
        {
            fuel -= 5;
            Console.WriteLine("Vehicle is moving...");
        }
    }

    class Car : Vehicle
    {
        private int passengers;

        public Car(int speed, int fuel, int passengers) : base(speed, fuel)
        {
            this.passengers = passengers;
        }

        public override void Drive()
        {
            fuel -= 10;
            Console.WriteLine("Car is moving with passengers...");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
        }
    }

    class Truck : Vehicle
    {
        private int cargoWeight;

        public Truck(int speed, int fuel, int cargoWeight) : base(speed, fuel)
        {
            this.cargoWeight = cargoWeight;
        }

        public override void Drive()
        {
            fuel -= 15;
            Console.WriteLine("Truck is moving with cargo...");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo Weight: {cargoWeight} kg");
        }
    }
}
