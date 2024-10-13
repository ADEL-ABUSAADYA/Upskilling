namespace ASS2.Media_Player_Plugins;

public class Audio : IMedia
{
    public void Play()
    {
        Console.WriteLine("Playing audio file.");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping audio playback.");
    }
}
