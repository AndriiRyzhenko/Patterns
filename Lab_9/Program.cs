using Lab_9;
using Lab_9.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IVideoUploaderFacade uploader = new VideoUploaderFacade("0711CD9A-02E9-4358-ACE9-D778BA9CA6D7");

        uploader.UploadVideo(@"C:\Movies\Video4.avi");

        /*
        Console shows next:

        Video Video4.avi converted to YouTube format!
        Path to converted video: C:\Movies\converted_Video4.avi
        Connect to YouTube API by key: 0711CD9A-02E9-4358-ACE9-D778BA9CA6D7
        Video converted_Video4.avi uploaded to YouTube!
        */
    }
}
