using System;

namespace MediaPlayer
{
    public class Song
    {
        public string File { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public string Comment { get; set; }
        public string Genre { get; set; }

        public Song()
        { }
    }
}
