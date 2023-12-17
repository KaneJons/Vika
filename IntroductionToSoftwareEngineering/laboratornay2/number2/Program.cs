namespace number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 10);
            int y = rnd.Next(1, 10);
            Console.Write($"{x} * {y} = ");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == x * y)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }
    }
}
