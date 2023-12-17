namespace number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите первое целое число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число для проверки");
            int userInput = int.Parse(Console.ReadLine());

            int numberToCheck = 6;
            int remainder = number1 % number2;
            int quotient = number1 / number2;

            if (numberToCheck % userInput == 0)
            {
                Console.WriteLine($"Число {userInput} является делителем числа 6");
            }
            else
            {
                Console.WriteLine($"Число {userInput} НЕ является делителем числа 6");

            }

            string itog = $"Частное: {quotient}";

            if (remainder == 0)
            {
                Console.WriteLine($"Число {number2} является делителем числа {number1}");

            }
            else
            {
                Console.WriteLine($"Число {number2} НЕ является делителем числа {number1}");
                itog += $", Остаток: {remainder}";
            }


            Console.WriteLine(itog);

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.WriteLine("Ввести число:");
            int a = int.Parse(Console.ReadLine());

            if (a % 4 == 0)
                Console.WriteLine($"Число {a} является кратным 4;");
            else
                Console.WriteLine($"Число {a} НЕ является кратным 4;");

            if (a  % 10 == 2)
                Console.WriteLine($"Число {a} оканчивается на 2.");
            else
                Console.WriteLine($"Число {a} НЕ оканчивается на 2.");


            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 0;

            if (x > 0)
            {
                y = Math.Sin(x+1);
            }
            else if (x < 0)
            {
                y = 3*Math.Cos(Math.Abs(x));
            }

            Console.WriteLine($"y = {Math.Round(y,5)}, при x = {x}");


            Console.WriteLine();
            Console.WriteLine("Задание 4");

            Console.Write("Введите сумму покупки: ");
            double purchaseAmount;
            if (double.TryParse(Console.ReadLine(), out purchaseAmount) && purchaseAmount > 0) // TryParse проверка на тип double
            {
                double discountRate = 0.0;
                if (purchaseAmount <= 8000)
                {
                    discountRate = 0.01;
                }
                else if (purchaseAmount <= 10000)
                {
                    discountRate = 0.05;
                }
                else if (purchaseAmount > 10000)
                {
                    discountRate = 0.1;
                }

                double discountAmount = purchaseAmount * discountRate;
                double totalAmount = purchaseAmount - discountAmount;

                Console.WriteLine($"Размер бонусной скидки: {discountAmount}");
                Console.WriteLine($"Итоговая сумма к оплате: {totalAmount}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное число.");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 5");

            Console.Write("Введите сумму покупки: ");
             purchaseAmount = 0;
            double retingDiscount = 0;
            if (double.TryParse(Console.ReadLine(), out purchaseAmount) && purchaseAmount > 0)
            {
                double discountRate = 0.0;
                if (purchaseAmount <= 2500)
                {
                    discountRate = 0.01;
                }
                else if (purchaseAmount <= 4500)
                {
                    discountRate = 0.03;
                }
                else if (purchaseAmount > 5000)
                {
                    discountRate = 0.05;
                }

                Console.Write("Введите рейтинг покупателя:");

                int reiting = int.Parse(Console.ReadLine()); ;

                switch (reiting)
                {
                    case 0:
                        break;
                    case 1:
                        retingDiscount = 100;
                        break;
                    case 2:
                        retingDiscount = 200;
                        break;
                    case 3:
                        retingDiscount = 300;
                        break;
                    case 4:
                        retingDiscount = 400;
                        break;
                    case 5:
                        retingDiscount = 500;
                        break;
                    default:
                        retingDiscount = -1;
                        break;
                }

                double discountAmount = purchaseAmount * discountRate;

                if (retingDiscount < 0)
                {
                    Console.WriteLine("Значение рейтинга было указано не верно. Он не будет учитываться в подсчёте итоговой суммы и бонусной скидки");
                }
                else
                {
                    discountAmount += retingDiscount;

                }
                double totalAmount = purchaseAmount - discountAmount;

                Console.WriteLine($"Размер бонусной скидки: {discountAmount}");
                Console.WriteLine($"Итоговая сумма к оплате: {totalAmount}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное число.");
            }
        }
    }
}
