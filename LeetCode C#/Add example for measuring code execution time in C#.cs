using System;

class Program
{
    // Method to simulate a delay of 1 second
    public static void Time()
    {
        Thread.Sleep(1000);
    }

    static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();

        // Code block
        Time();

        timer.Stop();
        TimeSpan elapsedTime = timer.Elapsed;

        Console.WriteLine($"{elapsedTime.Seconds} s");
        Console.WriteLine($"{elapsedTime.TotalMilliseconds} ms");
    }
}