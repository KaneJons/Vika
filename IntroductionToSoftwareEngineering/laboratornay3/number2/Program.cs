namespace number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string playAgain;
            Random random = new Random();

            do
            {
                
                int secretNumber = random.Next(1, 101);
                int attempts = 0;

                Console.WriteLine("Угадайте число от 1 до 100.");

                while (true)
                {
                    Console.Write("Введите ваш вариант: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int userGuess))
                    {
                        attempts++;

                        if (userGuess < secretNumber)
                        {
                            Console.WriteLine("Недолет!");
                        }
                        else if (userGuess > secretNumber)
                        {
                            Console.WriteLine("Перелет!");
                        }
                        else
                        {
                            Console.WriteLine($"Молодец! В точку! Количество попыток: {attempts}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число.");
                    }
                }

                Console.Write("Начать заново? (Y/N): ");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "Y");

            Console.WriteLine("Игра окончена!!!");

            Console.WriteLine();
            Console.WriteLine("Задание 2");


            int totalAttempts = 0;
            int correctAnswers = 0;

            bool flag = true;

            while (flag)
            {
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);

                Console.Write($"{num1} * {num2} = ");

                int userAnswer;
                if (int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    int correctResult = num1 * num2;
                    if (userAnswer == correctResult)
                    {
                        Console.WriteLine("Верно!");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Неверно. Правильный ответ: {correctResult}");
                    }

                    totalAttempts++;
                }
                else
                {
                    Console.WriteLine("Введите корректное число.");
                }

                Console.WriteLine("Продолжить? (Y/N): ");
                string x = Console.ReadLine();
                while (x != "Y" && x != "N")
                {
                    Console.WriteLine("Вы ввели не из предлежнных вариантов ответ. Пожалуйста ответьти (Y/N): ");
                    x = Console.ReadLine();
                }
                flag = x == "Y" ? true : false;
            }


            Console.WriteLine($"Всего попыток - {totalAttempts}");
            Console.WriteLine($"Верных ответов - {correctAnswers} ({((double)correctAnswers / totalAttempts) * 100:F1}%)");
            Console.WriteLine($"Неверных ответов - {totalAttempts - correctAnswers} ({((double)(totalAttempts - correctAnswers) / totalAttempts) * 100:F1}%)");


            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.Write("Введите начало диапазона a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите конец диапазона b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Простые числа в диапазоне от {a} до {b}:");

            for (int i = a; i <= b; i++)
            {
                if (i > 1)
                {
                     flag = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
