using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProduct
    {
        void DisplayInfo();
    }

    public interface IShoppable
    {
        void AddToCart();
    }
    public class ElectronicDevice : IProduct
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }

        public ElectronicDevice(string name, string manufacturer, decimal price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Name}, Виробник: {Manufacturer}, Ціна: {Price:C}");
        }
    }
    public class Smartphone : ElectronicDevice, IShoppable
    {
        public string OperatingSystem { get; set; }
        public int CameraMegapixels { get; set; }

        public Smartphone(string name, string manufacturer, decimal price, string operatingSystem, int cameraMegapixels)
            : base(name, manufacturer, price)
        {
            OperatingSystem = operatingSystem;
            CameraMegapixels = cameraMegapixels;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Операційна система: {OperatingSystem}, Камера: {CameraMegapixels} МП");
        }

        public void AddToCart()
        {
            Console.WriteLine($"Смартфон \"{Name}\" додано до кошика.");
        }
    }
    public class Laptop : ElectronicDevice, IShoppable
    {
        public string Processor { get; set; }
        public int RAM { get; set; } // в ГБ

        public Laptop(string name, string manufacturer, decimal price, string processor, int ram)
            : base(name, manufacturer, price)
        {
            Processor = processor;
            RAM = ram;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Процесор: {Processor}, Оперативна пам'ять: {RAM} ГБ");
        }

        public void AddToCart()
        {
            Console.WriteLine($"Ноутбук \"{Name}\" додано до кошика.");
        }
        static void Main(string[] args)
        {
            // Створюємо смартфони
            Smartphone smartphone1 = new Smartphone("iPhone 14", "Apple", 999.99m, "iOS", 12);
            Smartphone smartphone2 = new Smartphone("Galaxy S21", "Samsung", 799.99m, "Android", 64);

            // Виводимо інформацію про смартфони
            smartphone1.DisplayInfo();
            smartphone1.AddToCart();

            smartphone2.DisplayInfo();
            smartphone2.AddToCart();

            // Створюємо ноутбуки
            Laptop laptop1 = new Laptop("Dell XPS 13", "Dell", 1299.99m, "Intel i7", 16);
            Laptop laptop2 = new Laptop("MacBook Air", "Apple", 999.99m, "Apple M1", 8);

            // Виводимо інформацію про ноутбуки
            laptop1.DisplayInfo();
            laptop1.AddToCart();

            laptop2.DisplayInfo();
            laptop2.AddToCart();
            Console.ReadLine();
        }
    }
    
}
