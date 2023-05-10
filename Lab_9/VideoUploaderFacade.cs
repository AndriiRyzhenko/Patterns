using Lab_9.Interfaces;

namespace Lab_9;

public class VideoUploaderFacade : IVideoUploaderFacade
{
    private readonly IYouTubeApi api;
    private readonly IVideoConverter converter;

    public VideoUploaderFacade(string apiKey)
    {
        api = new YouTubeApi(apiKey);
        converter = new VideoConverter();
    }

    public void UploadVideo(string filePath)
    {
        string convertedFilePath = converter.ConvertVideo(filePath);
        api.UploadVideo(convertedFilePath);
    }
}
