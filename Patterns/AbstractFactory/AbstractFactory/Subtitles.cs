using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Subtitles
    {
        public void SetLanguage(string language)
        {
            Console.WriteLine("Subtitles language -> " + language);
        }
        public Subtitles() { }
    }
}
