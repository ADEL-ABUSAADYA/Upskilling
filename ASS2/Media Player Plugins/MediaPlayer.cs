namespace ASS2.Media_Player_Plugins;

public class MediaPlayer
{
    private List<IMedia> _mediaList;

    public MediaPlayer()
    {
        _mediaList = new List<IMedia>();
    }

    // Add a media file to the media list
    public void AddMedia(IMedia media)
    {
        _mediaList.Add(media);
    }

    // Play all media files in the list
    public void PlayAll()
    {
        if (_mediaList.Count == 0)
        {
            Console.WriteLine("No media loaded.");
            return;
        }

        foreach (var media in _mediaList)
        {
            media.Play();
        }
    }

    // Stop all media files in the list
    public void StopAll()
    {
        if (_mediaList.Count == 0)
        {
            Console.WriteLine("No media loaded.");
            return;
        }

        foreach (var media in _mediaList)
        {
            media.Stop();
        }
    }
}