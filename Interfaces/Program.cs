using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Interfaces
{
    internal interface IVehicle
    {
        void Start();
        void Stop();
        void Drive();
    }
    class Car: IVehicle
    {
        public string Mark { get; set; }
        public double Year { get; set; }
        public string Model { get; set; }
        public Car(string model, string mark, double year)
        { Model = model;
          Mark = mark;
          Year = year;
        }
        public void Start()
        {
            Console.WriteLine($"Машина {Year} {Model} {Mark} завелась");
        }
        public void Stop()
        {
            Console.WriteLine($"Машина {Year} {Model} {Mark} зупинилась");
        }
        public void Drive()
        {
            Console.WriteLine($"Машина {Year} {Model} {Mark} поїхала");
        }
    }
    class Motorcycle: IVehicle
    {
        public string Mark { get; set; }
        public double Year { get; set; }
        public string Model { get; set; }
        public Motorcycle(string model, string mark, double year)
        { Model = model;
          Mark = mark;
          Year = year;
        }
        public void Start()
        {
            Console.WriteLine($"Мотоцикл {Year} {Model} {Mark} завівся");
        }
        public void Stop()
        {
            Console.WriteLine($"Мотоцикл {Year} {Model} {Mark} зупинився");
        }
        public void Drive()
        {
            Console.WriteLine($"Мотоцикл {Year} {Model} {Mark} поїхав");
        }

    }
    class Truck: IVehicle
    {
        public string Mark { get; set; }
        public double Year { get; set; }
        public string Model { get; set; }
        public double LoadCapacity { get; set; } // у тоннах
        public Truck(string model, string mark, double year, double loadCapacity)
        {
            Model = model;
            Mark = mark;
            Year = year;
            LoadCapacity = loadCapacity;
        }
        public void Start()
        {
            Console.WriteLine($"Вантажівка {Year} {Model} {Mark} завелась");
        }
        public void Stop()
        {
            Console.WriteLine($" Вантажівка {Year} {Model} {Mark} зупинилась");
        }
        public void Drive()
        {
            Console.WriteLine($"{Year} {Model} {Mark} вантажівка поїхала з вантажопідйомністю {LoadCapacity}");
        }
        static void Main(string[] args)
        {
            IVehicle myCar = new Car("X5", "BMW", 2020);
            myCar.Start();
            myCar.Drive();
            myCar.Stop();

            IVehicle myMotorcycle = new Motorcycle("Kawasaki", "Ninja H2 R", 2019);
            myMotorcycle.Start();
            myMotorcycle.Drive();
            myMotorcycle.Stop();

            IVehicle myTruck = new Truck("Volvo", "FH16", 2021, 18);
            myTruck.Start();
            myTruck.Drive();
            myTruck.Stop();
            Console.ReadLine();
        }
    }

}*/
