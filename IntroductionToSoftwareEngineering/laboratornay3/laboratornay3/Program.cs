namespace laboratornay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int counter = 0;
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                    sum += i;
                }
            }
            Console.WriteLine($"Количество четных чисел от 1 до 100: {counter}");
            Console.WriteLine($"Сумма четных чисел от 1 до 100: {sum}");

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.Write("Введите значение для переменной а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для переменной b: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 10 == 5)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 3");

            int k = 0;
            bool flag = false;
            bool krfive = false;
            int max = -1;
            int x = -30000;

            Console.WriteLine("Введите количество последовательности:");
            while (k <= 0 || k >= 1000)
            {
                if (flag)
                {
                    Console.WriteLine("Вы ввели неверное значени!!! Введите число не меньше 1 и не больше 1000.");
                }
                k = int.Parse(Console.ReadLine());
                flag = true;
            }
            flag = false;

            Console.WriteLine("Введите числа последовательности:");
            for (int i = 0; i < k; i++)
            {
                while (x <= -30000 || x >= 30000)
                {
                    if (flag)
                    {
                        Console.WriteLine("Вы ввели неверное значение!!! Введите число , которое не меньше -30000 и не больше 30000");
                    }
                    x = int.Parse(Console.ReadLine());
                    flag = true;
                }
                flag = false;
                if (!krfive)
                {
                    krfive = x % 5 == 0;
                }
                if (x % 5 == 0)
                {
                    max = max < x ? x : max;
                }
                x = -30000;
            }
            if (krfive)
            {
                Console.WriteLine($"Максимальное число кратное 5: {max}");
            }
            else
            {
                Console.WriteLine("В последовательности не было ни одного числа кратного 5.");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 4");

            Console.Write("Введите число: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                bool isPrime = true;

                if (number <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{number} - простое число");
                }
                else
                {
                    Console.WriteLine($"{number} - не является простым числом");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является числом.");
            }
        }
    }
}
