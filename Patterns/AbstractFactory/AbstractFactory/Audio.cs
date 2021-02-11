using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Audio :IAudio
    {
        public void SetLanguage(string language)
        {
            Console.WriteLine("Audio language -> " + language);
        }
        public Audio() { }
    }
}
