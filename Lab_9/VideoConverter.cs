using Lab_9.Interfaces;

namespace Lab_9;

public class VideoConverter : IVideoConverter
{

    public string ConvertVideo(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), "converted_" + fileName);
        Console.WriteLine($"Video {fileName} converted to YouTube format!");
        Console.WriteLine($"Path to converted video: {newFilePath}");
        return newFilePath;
    }
}
