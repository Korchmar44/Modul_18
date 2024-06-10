using YoutubeExplode;

namespace Task_18_4_1.Interface
{
    // Интерфейс команды
    interface ICommand
    {
        Task Execute(YoutubeClient client, string videoUrl);
    }
}
