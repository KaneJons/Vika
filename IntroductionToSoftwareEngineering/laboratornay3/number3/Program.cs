namespace number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            int counter = 0;
            int sum = 0;
            Console.Write("Введите число а = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b = ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                counter = i % 5 == 0 ? counter + 1 : counter;
                sum = i % 5 == 0 ? sum + i : sum;
            }
            Console.WriteLine($"Количество чисел , кратных 5: {counter}");
            Console.WriteLine($"Сумма всех чисел , кратных 5: {sum}");

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.Write("Введите сумму вклада: ");
            double startSuma = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int countMonth = Convert.ToInt32(Console.ReadLine());

            const double procentStav = 8.0;

            for (int месяц = 1; месяц <= countMonth; месяц++)
            {
                startSuma += startSuma * (procentStav / 100.0);
            }

            Console.WriteLine($"Конечная сумма вклада после {countMonth} месяцев: {Math.Round(startSuma,2)}");

            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Таблица умножения:");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j} * {i} = {j * i}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 6; j <= 9; j++)
                {
                    Console.Write($"{j} * {i} = {j * i}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
