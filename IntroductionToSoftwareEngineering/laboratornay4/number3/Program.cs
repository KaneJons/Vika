namespace number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            List<int> numbers = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int randomNumber = random.Next(1, 100);
                numbers.Add(randomNumber);
            }

            Console.Write("Введите приветствие: ");
            string greeting = Console.ReadLine();

            Console.WriteLine("Приветствие: " + greeting);
            Console.WriteLine("Случайные числа:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Задача 2");

            Console.WriteLine("Введите количество элементов N:");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {

                List<object> elements = new List<object>();

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите элемент {i + 1}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out _))
                    {
                        elements.Add(double.Parse(input));
                    }
                    else
                    {

                        elements.Add(input);
                    }
                }

                int numericCount = 0;
                int nonNumericCount = 0;

                foreach (var element in elements)
                {
                    if (element is double)
                    {
                        numericCount++;
                    }
                    else
                    {
                        nonNumericCount++;
                    }
                }

                Console.WriteLine($"Количество числовых элементов: {numericCount}");
                Console.WriteLine($"Количество нечисловых элементов: {nonNumericCount}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите положительное целое число для количества элементов.");
            }
        }
    }
}
