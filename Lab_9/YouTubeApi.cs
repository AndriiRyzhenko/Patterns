using Lab_9.Interfaces;

namespace Lab_9;

public class YouTubeApi : IYouTubeApi
{
    private readonly string apiKey;

    public YouTubeApi(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public void UploadVideo(string filePath)
    {
        Console.WriteLine($"Connect to YouTube API by key: {apiKey}");
        Console.WriteLine($"Video {Path.GetFileName(filePath)} uploaded to YouTube!");
    }
}
