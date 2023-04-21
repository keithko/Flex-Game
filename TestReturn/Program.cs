namespace TestReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Getallen(random);
        }
        static object Getallen(Random random)
        {
            int rol = random.Next(1, 101);
            Console.WriteLine(rol);
            return Getallen;
        }
    }
}
