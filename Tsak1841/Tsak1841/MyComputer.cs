using System;
using System.IO;
using YoutubeExplode;

namespace Tsak1841
{
    /// <summary>
    /// Адресат
    /// </summary>
    public class MyComputer : YoutubeClient
    {
        private string url;
        private string outputFilePath;

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = (value == String.Empty) ? "https://www.youtube.com/watch?v=nMjwkh3CvkY" : value;
            }
        }

        public string OutputFilePath
        {
            get
            {
                return outputFilePath;
            }
            set
            {
                outputFilePath = (value == String.Empty) ? string.Concat(Directory.GetCurrentDirectory(), @"\newVideo.mp4") : value;
            }
        }

        public MyComputer(string url, string outputFilePath)
        {
            Url = url;
            OutputFilePath = outputFilePath;
            Videos.GetAsync(Url); //получить описание видео
        }
    }
}
