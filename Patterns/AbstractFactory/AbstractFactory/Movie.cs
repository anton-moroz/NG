using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Movie : IMovie
    {
        Audio audio;
        Subtitles subtitles;
        public Movie() 
        {
            SetSubtitles();
            SetAudio();
        }
        public void SetSubtitles()
        {
            this.subtitles = new Subtitles();
        }
        public void SetAudio()
        {
            this.audio = new Audio();
        }
        public void SetLanguage(string _language)
        {
            audio.SetLanguage(_language);
            subtitles.SetLanguage(_language);
        }
    }
}
