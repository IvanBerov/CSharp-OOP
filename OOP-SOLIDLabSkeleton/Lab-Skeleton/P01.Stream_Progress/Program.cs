using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Aziz", "Sait Trope", 40, 20);
            StreamProgressInfo streamProgress = new StreamProgressInfo(music);
            Console.WriteLine($"{streamProgress.CalculateCurrentPercent()} % send");

            File file = new File("Beat boys", 100, 30);
            StreamProgressInfo stream = new StreamProgressInfo(file);
            Console.WriteLine($"{stream.CalculateCurrentPercent()} % send");
        }
    }
}
