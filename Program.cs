namespace Rabota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x:");
            int x = int.Parse(Console.ReadLine());
            double y = Math.Pow(x, 2) + 3;
            y /= 2;
            Console.WriteLine($"y = {y}");
        }
    }
}
