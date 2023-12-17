namespace laboratornay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            double lenghtCircle, square, volume;
            Console.WriteLine("Введите значения для радиуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            lenghtCircle = 2 * Math.PI * radius;
            square = Math.PI * Math.Pow(radius, 2);
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

            Console.WriteLine($"Длина окружности: {Math.Round(lenghtCircle, 5)}; Площадь круга: {Math.Round(square, 5)}; Объем сферы: {Math.Round(volume, 5)}");
            Console.WriteLine();
            Console.WriteLine("Задание 2");

            int a , b;
            Console.WriteLine("Введите в переменную а:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в переменную b:");
            b = Convert.ToInt32(Console.ReadLine());

            (a, b) = (b, a);
            Console.WriteLine($"Новые значения для переменных a = {a}; b = {b}");

            Console.WriteLine();
            Console.WriteLine("Задание 3");
            a = 0;
            int sum = 0, product = 0;

            Console.WriteLine("Введите произвольное число: ");
            a = Convert.ToInt32(Console.ReadLine());

            b = a / 100; 
            int c = (a / 10) % 10, d = a % 10;

            sum = b + c + d;
            product = b * c * d;

            Console.WriteLine($"Сумма чисел: {sum}; Произведение чисел: {product}");

            Console.WriteLine();
            Console.WriteLine("Задание 4");

            Console.WriteLine("Введите трехзначное число:");
            a = Convert.ToInt32(Console.ReadLine());
            a = (100 * (a % 10)) + (10 * ((a / 10) % 10)) + (a / 100);
            Console.WriteLine(a);
        }
    }
}
