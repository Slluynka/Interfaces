using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Interfaces
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IBorrowable
    {
        void BorrowItem();
        void ReturnItem();
        bool IsAvailable();
    }
    public class Book : IPrintable, IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        private bool isAvailable;

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            isAvailable = true; // Книга доступна при створенні
        }

        public void Print()
        {
            Console.WriteLine($"Назва: {Title}, Автор: {Author}, Рік видання: {YearPublished}," +
                $" Доступність: {(isAvailable ? "Доступна" : "Взята")}");
        }

        public void BorrowItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Книга \"{Title}\" була взята.");
            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" вже взята.");
            }
        }

        public void ReturnItem()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"Книга \"{Title}\" була повернена.");
            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" вже доступна.");
            }
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }
        static void Main(string[] args)
        {
            // Створюємо книги
            Book book1 = new Book("1984", "Джордж Орвелл", 1949);
            Book book2 = new Book("Володар перснів", "Джон Р. Р. Толкін", 1954);
            Book book3 = new Book("Мобі Дік", "Герман Мелвілл", 1851);

            // Виводимо інформацію про книги
            book1.Print();
            book2.Print();
            book3.Print();

            // Тестуємо функціональність позички
            book1.BorrowItem();
            book1.Print(); // Перевіряємо доступність
            book1.BorrowItem(); // Спроба повторного позичання

            book1.ReturnItem(); // Повертаємо книгу
            book1.Print(); // Перевіряємо доступність після повернення

            Console.ReadLine();
        }
    }
}*/
