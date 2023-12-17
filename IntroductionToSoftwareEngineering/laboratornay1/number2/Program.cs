namespace number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите периметер P: ");
            double P = Convert.ToDouble(Console.ReadLine());

            double b;
                 b = (P-a) / 2;

            Console.WriteLine("Найденое значение двух сторон: {0}", b);
        }
    }
}
