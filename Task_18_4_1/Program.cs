using Task_18_4_1.Command;
using Task_18_4_1.Interface;
using Task_18_4_1.ServiceCommsnd;
using YoutubeExplode;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new YoutubeClient();

        Console.Write("Введите ссылку на Youtube-видео: ");
        string videoUrl = Console.ReadLine();

        ICommand getVideoInfoCommand = new GetVideoInfoCommand();
        ICommand downloadVideoCommand = new DownloadVideoCommand(); //При скачивании ошибка 400, пока не знаю как победить

        await getVideoInfoCommand.Execute(client, videoUrl);
        await downloadVideoCommand.Execute(client, videoUrl);
    }
}
