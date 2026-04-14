using System;
using System.Diagnostics;
using System.Media;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "wmplayer",
                Arguments = "greeting.wav",
                UseShellExecute = true
            });
        }
        catch
        {
            Console.WriteLine("🔇 Audio file missing or failed to play.");
        }
    }
}
