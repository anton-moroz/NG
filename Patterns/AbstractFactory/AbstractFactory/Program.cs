using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();

            movie.SetLanguage("English");

            Console.WriteLine();

            movie.SetLanguage("Ukrainian");
            Console.WriteLine("\nTap Enter to exit...");
            Console.ReadLine();
        }
    }
}
