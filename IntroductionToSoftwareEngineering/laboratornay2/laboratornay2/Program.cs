namespace laboratornay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"Число {a} - четное");
                }
                else
                {
                    Console.WriteLine($"Число {a} - не четное");
                }
            }
            else
            {
                Console.WriteLine("Ноль");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 2");

             a = Convert.ToInt32(Console.ReadLine());

            if (a > 9 && a < 100)
            {
                if (a % 10 == 3)
                {
                    Console.WriteLine($"Заданное число является двузначным и оканчивается на 3");
                }
                else
                {
                    Console.WriteLine($"Заданное число является двузначным, но не оканчивается на 3");

                }
            }
            else
            {
                Console.WriteLine($"Заданное число не является двузначным числом");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите сумму вклада:");
            double b = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double procent = 0;

            if (b < 100)
            {
                procent = 0.05;
            }
            else if (b > 99 && b <= 200)
            {
                procent = 0.07;
            }
            else if (b > 200)
            {
                procent = 0.1;
            }
            sum += b + (b * procent);
            Console.WriteLine($"Общая сумма с начисленными процентами: {sum} тыс. руб");

            Console.WriteLine();
            Console.WriteLine("Задание 4");

            Console.WriteLine("Введите первую переменную уравнения:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную уравнения:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью переменную уравнения:");
            double z = Convert.ToDouble(Console.ReadLine());


            double D = Math.Pow(y, 2) - 4 * x * z;

            if (D > 0)
            {
                Console.WriteLine($"x1 = {(-y + Math.Sqrt(D)) / (2 * x)};\n" +
                    $"x2 = {(-y - Math.Sqrt(D)) / (2 * x)}");
            }
            else if (D == 0)
            {
                Console.WriteLine($"x1 = x2 = {(-y) / (2 * x)}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 5");

            Console.WriteLine("Введите номер недели:");
            int n = Convert.ToInt32(Console.ReadLine());
            string day;

            switch (n)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье";
                    break;
                default:
                    day = "Такого дня недели не существует";
                    break;
            }
            Console.WriteLine(day);
        }

    }
}
