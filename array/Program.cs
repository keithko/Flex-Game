using System.Reflection.Metadata.Ecma335;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = { 10, 20, 30, 40, 50, 60 };
            getallen(nummer);
        }
        
        static int getallen(int [] nummer){  int som = 0;

            for (int num = 0; num < 5; num++)
            {
                int getal = nummer[num];
                som += getal;
                Console.WriteLine(getal + som);
            } return som;
        }
    }
}