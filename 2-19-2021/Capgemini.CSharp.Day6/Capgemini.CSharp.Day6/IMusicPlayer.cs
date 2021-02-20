using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day6
{
    public interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Previous();
        void Next();
        void Stop();
        
    }

    public interface IAdvancePlayer
    {
        void ShowLyrics();
    }
}
