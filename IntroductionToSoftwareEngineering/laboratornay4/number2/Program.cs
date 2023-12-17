namespace number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая задача");

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

            Console.WriteLine("\nРешение второй задачи");

            //1)

            Array.Sort(array);

            Console.WriteLine("\nОтсортированный массив:");

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            //2)

            Console.Write("Введите число для поиска: ");
            int searchNumber;

            while (!int.TryParse(Console.ReadLine(), out searchNumber))
            {
                Console.WriteLine("Введите корректное целое число.");
                Console.Write("Попробуйте снова: ");
            }

            int index = Array.IndexOf(array, searchNumber);

            if (index != -1)
            {
                Console.WriteLine($"Число {searchNumber} найдено в массиве. Порядковый номер: {index + 1}");
            }
            else
            {
                Console.WriteLine($"Такого числа {searchNumber} в массиве нет.");
            }

            Console.WriteLine();

            //3)

            int[] A = new int[20];
            int[] B;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(0, 1001);
            }

            Console.WriteLine("Исходный массив A:");

            foreach (int number in A)
            {
                Console.Write(number + " ");
            }

            B = Array.FindAll(A, x => x <= 888);

            Array.Sort(B, (a, b) => b.CompareTo(a));

            Console.WriteLine("\nМассив B, удовлетворяющий условию A[i] <= 888 и отсортированный по убыванию:");

            foreach (int number in B)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
