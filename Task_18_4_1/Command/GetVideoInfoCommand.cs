using Task_18_4_1.Interface;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Task_18_4_1.Command
{
    // Команда для получения информации о видео
    class GetVideoInfoCommand : ICommand
    {
        public async Task Execute(YoutubeClient client, string videoUrl)
        {
            Video video = await client.Videos.GetAsync(videoUrl); // Получаем видео по URL
            Console.WriteLine($"Название видео: {video.Title}"); // Выводим название видео
            Console.WriteLine($"Описание: {video.Description}"); // Выводим описание видео
        }
    }
}
