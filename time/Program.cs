using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Threading;


namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //thread
            //clear console
            while (true )  
            {
                DateTime date1 = DateTime.Now;
                Console.WriteLine(date1);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}