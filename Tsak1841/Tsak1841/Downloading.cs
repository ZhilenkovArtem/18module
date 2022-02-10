using System;
using YoutubeExplode.Converter;

namespace Tsak1841
{
    public class Downloading : Command
    {
        MyComputer myComputer;

        public Downloading(MyComputer myComputer)
        {
            this.myComputer = myComputer;
        }

        // Выполнить
        public async override void Run()
        {
            Console.WriteLine("Начали");
            await myComputer.Videos.DownloadAsync(myComputer.Url, myComputer.OutputFilePath); //запустить скачивание видео
            Console.WriteLine("Закончили");
        }
    }
}
