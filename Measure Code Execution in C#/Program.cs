using System.Diagnostics;

namespace Measure_Code_Execution_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Code block to be measured


            timer.Stop();
            TimeSpan elapsedTime = timer.Elapsed;

            Console.WriteLine($"{elapsedTime.Seconds} s");
            Console.WriteLine($"{elapsedTime.TotalMilliseconds} ms");
        }
    }
}
