namespace laboratornay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
            }

            Console.WriteLine("Случайные натуральные числа в диапазоне от 0 до 100:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            // a)
            int maxElement = array[0];
            int minElement = array[0];
            int maxPosition = 0;
            int minPosition = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxPosition = i;
                }

                if (array[i] < minElement)
                {
                    minElement = array[i];
                    minPosition = i;
                }
            }

            Console.WriteLine($"Наибольший элемент: {maxElement}, позиция: {maxPosition}");
            Console.WriteLine($"Наименьший элемент: {minElement}, позиция: {minPosition}");

            Console.WriteLine();

            //б)

            int count = array.Length;
            int sum = 0;
            int product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                product *= array[i];
            }


            Console.WriteLine($"Количество элементов: {count}");
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Произведение элементов: {product}");

            Console.WriteLine();

            //в)

            int evenCount = 0;
            int oddCount = 0;
            int zeroCount = 0;

            foreach (int number in array)
            {
                if (number == 0)
                {
                    zeroCount++;
                }
                else if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Количество четных элементов: {evenCount}");
            Console.WriteLine($"Количество нечетных элементов: {oddCount}");
            Console.WriteLine($"Количество нулевых элементов: {zeroCount}");

            Console.WriteLine();

            //г)

            int oddSum = 0;
            int oddCountFive = 0;

            foreach (int number in array)
            {
                if (number % 2 != 0 && number % 5 == 0)
                {
                    oddSum += number;
                    oddCountFive++;
                }
            }

            Console.WriteLine($"Сумма нечетных элементов, кратных 5-ти: {oddSum}");
            Console.WriteLine($"Количество нечетных элементов, кратных 5-ти: {oddCountFive}");

            Console.WriteLine();

            //д)

            int sumthrenin = 0;
            int countthrenin = 0;

            foreach (int number in array)
            {
                if (number % 3 == 0 && number % 10 == 9)
                {
                    sumthrenin += number;
                    countthrenin++;
                }
            }

            Console.WriteLine($"Сумма элементов, кратных 3 и заканчивающихся на 9: {sumthrenin}");
            Console.WriteLine($"Количество элементов, кратных 3 и заканчивающихся на 9: {countthrenin}");

            Console.WriteLine("Задание 2");

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    numbers[i] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите целое число.");
                    i--;
                }
            }

            bool ascending = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    ascending = false;
                    break;
                }
            }

            bool descending = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    descending = false;
                    break;
                }
            }

            if (ascending)
            {
                Console.WriteLine("Массив упорядочен по возрастанию.");
            }
            else if (descending)
            {
                Console.WriteLine("Массив упорядочен по убыванию.");
            }
            else
            {
                Console.WriteLine("Массив неупорядочен.");
            }
        }
    }
}
