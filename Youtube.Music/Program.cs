using System;
using WebWindows;

namespace Youtube.Music
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new WebWindow("Youtube Music");
            window.NavigateToUrl("https://music.youtube.com");
            window.WaitForExit();
        }
    }
}
