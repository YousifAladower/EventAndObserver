namespace EventAndObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubChannel youtubChannel = new YoutubChannel();
            Subscriber subscriber = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();
            subscriber.Subscribe(youtubChannel);
            subscriber2.Subscribe(youtubChannel);
            subscriber3.Subscribe(youtubChannel);
            youtubChannel.UploadVideo("C#");
        }
    }
}

public delegate void dl(string videoTitle);
public class YoutubChannel
{
    public dl dlUpload;
    public void UploadVideo(string videoTitle)
    {
        Console.WriteLine($"Video uploaded {videoTitle}");
        dlUpload(videoTitle);
    }
}

public class Subscriber
{
    public void Subscribe(YoutubChannel channel)
    {
        channel.dlUpload += watchVide;
    }
    public void watchVide(string videoTitle)
    {
        Console.WriteLine($"Watching {videoTitle}");

    }
}
