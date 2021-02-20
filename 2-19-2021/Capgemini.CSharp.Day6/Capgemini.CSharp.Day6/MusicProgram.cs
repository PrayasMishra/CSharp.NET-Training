using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
    class MusicProgram
    {
        static void Main(string[] args)
        {
            Spotify spo = new Spotify();
            spo.Play();
            spo.Pause();
            spo.Stop();
            spo.Next();
            spo.Previous();
            spo.ShowLyrics();

            Gaana ga = new Gaana();
            ga.Play();
            ga.Pause();
            ga.Stop();
            ga.Next();
            ga.Previous();
            

            ReadKey();
        }
    }
}
