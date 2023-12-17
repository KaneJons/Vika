namespace number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.251, y = 0.325, z = 0.466 * 0.0001;

            double c = Math.Pow(2, Math.Pow(y, x))+Math.Pow(Math.Pow(3,x),y) - ((y * (Math.Atan(z)-(Math.PI/6)))/(Math.Abs(x) + (1/(Math.Pow(y,2)+1))));
            
            Console.WriteLine(Math.Round(c,6));
        }
    }
}
