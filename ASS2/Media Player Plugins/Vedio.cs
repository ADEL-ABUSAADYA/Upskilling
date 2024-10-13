namespace ASS2.Media_Player_Plugins;

public class Video : IMedia
{
    public void Play()
    {
        Console.WriteLine("Playing video file.");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping video playback.");
    }
}