using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ManageTimeLibrary;

public class MeasureTime
{
    public static Stopwatch timer { get; set; } = new Stopwatch();

    public static void StartTimer() => timer.Start();

    public static void StopTimer() => timer.Stop();

    public static string TimeElapsed()
    {
        TimeSpan timeElapsed = timer.Elapsed;
        
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{1:00}",
            timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds,
            timeElapsed.Milliseconds / 10);
       
        return elapsedTime;
    }

}
