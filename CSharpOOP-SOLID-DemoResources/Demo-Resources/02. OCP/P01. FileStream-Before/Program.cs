using System;
using System.Threading;

namespace P01._FileStream_Before
{
    public class Program
    {
        static void Main(string[] args)
        {
            File file = new File();
            file.Sent = 0;
            file.Length = 500;

            Progress progress = new Progress(file);

            while (true)
            {
                file.Sent += 7;
                Console.WriteLine($"{progress.CurrentPercent()}% sent.");
                Thread.Sleep(200);

            }
        }
    }
}
