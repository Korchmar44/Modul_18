using Task_18_4_1.Interface;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task_18_4_1.ServiceCommsnd
{
    class DownloadVideoCommand : ICommand
    {
        public async Task Execute(YoutubeClient client, string videoUrl)
        {
            var video = await client.Videos.GetAsync(videoUrl); // Получаем информацию о видео

            var streamInfoSet = await client.Videos.Streams.GetManifestAsync(video.Id); // Получаем поток нужного нам видео

            var muxedStreamInfo = streamInfoSet.GetMuxedStreams().TryGetWithHighestVideoQuality(); // Выбираем видео поток с наивысшим качеством

            var videoFilePath = $"{Guid.NewGuid()}.mp4"; // Генерируем уникальное имя файла
            await client.Videos.Streams.DownloadAsync (muxedStreamInfo, videoFilePath); // Скачиваем видео

            Console.WriteLine($"Видео успешно скачано: {videoFilePath}"); // Выводим сообщение об успешном скачивании
        }
    }
}
