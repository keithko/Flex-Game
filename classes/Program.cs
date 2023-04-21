namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Rectangle(100, 200, 50, 50);
        }
    }
    internal class Rectangle
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            Console.WriteLine(x+y+width+height);
        }
    }
}