using System;

namespace Tsak1841
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите URL:");
            string videoURL = Console.ReadLine();
            Console.WriteLine("Введите, куда сохранить видео:");
            string outputFilePath = Console.ReadLine();
            
            var myComputer = new MyComputer(videoURL, outputFilePath);
            var youtube = new Youtube();
            youtube.SetCommand(new Downloading(myComputer));
            youtube.StartLoading();
            Console.ReadKey();
        }
    }
}
