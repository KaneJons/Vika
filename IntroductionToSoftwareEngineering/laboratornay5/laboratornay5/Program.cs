using exercise1;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise1
{
    public class Book
    {
        public int InvN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public static List<Book> BooksCollection = new List<Book>();

        public static void AddBook(int invN, string name, string author, int year, decimal price)
        {
            BooksCollection.Add(new Book
            {
                InvN = invN,
                Name = name,
                Author = author,
                Year = year,
                Price = price
            });

            Console.WriteLine("Книга успешно добавлена в каталог.");
        }

        public static void Catalog()
        {
            Console.WriteLine("Каталог книг:");

            decimal total = 0;

            foreach (var book in BooksCollection)
            {
                Console.WriteLine($"{book.InvN}\t{book.Name}\t{book.Author}\t{book.Year}\t{book.Price}");
                total += book.Price;
            }
            Console.WriteLine($"Общая стоимость всех книг: {total}");
        }

        public static void PriceCatalog(decimal maxPrice)
        {
            Console.WriteLine($"Каталог книг, стоимость которых ниже {maxPrice}.");

            foreach (var book in BooksCollection)
            {
                if (book.Price < maxPrice)
                {
                    Console.WriteLine($"{book.InvN}\t{book.Name}\t{book.Author}\t{book.Year}\t{book.Price}");
                }
            }
        }
    }
}

class BookStore
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Выберите действие:\n " +
                "0 - выход из программы, 1 - добавление книги, " +
                "2 - просмотр каталога книг, 3 - поиск книги");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Environment.Exit(0);
                    break;

                case "1":
                    Console.WriteLine("Введите данные книги:");

                    Console.Write("Инвентарный номер: ");
                    int invN = int.Parse(Console.ReadLine());

                    Console.Write("Название: ");
                    string name = Console.ReadLine();

                    Console.Write("Автор: ");
                    string author = Console.ReadLine();

                    Console.Write("Год выпуска: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Цена: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Book.AddBook(invN, name, author, year, price);
                    break;

                case "2":
                    Book.Catalog();
                    break;

                case "3":
                    Console.Write("Введите максимальную стоимость для поиска: ");
                    decimal maxPrice = decimal.Parse(Console.ReadLine());
                    Book.PriceCatalog(maxPrice);
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите существующую опцию.");
                    break;
            }

        }
    }
}