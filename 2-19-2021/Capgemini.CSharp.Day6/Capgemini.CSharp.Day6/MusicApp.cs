using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day6
{
	public class Spotify : IMusicPlayer, IAdvancePlayer
	{
		public void ShowLyrics()
		{
			WriteLine("lyrics..........(Spotify TM.)");
		}

		public void Next()
		{
			WriteLine("next song playing....(Spotify TM.)");
		}

		public void Pause()
		{
			WriteLine("pause song.....(Spotify TM.)");
		}

		public void Play()
		{
			WriteLine("play song......(Spotify TM.)");
		}

		public void Previous()
		{
			WriteLine("previous song playing.....(Spotify TM.)");
		}

		public void Stop()
		{
			WriteLine("stop song.....(Spotify TM.)");
		}
	}

    public class Gaana : IMusicPlayer
    {
        public void Next()
        {
			WriteLine("next song.....(Gaana)");
		}

        public void Pause()
        {
			WriteLine("pause.....(Gaana)");
		}

        public void Play()
        {
			WriteLine("playing song.....(Gaana)");
		}

        public void Previous()
        {
			WriteLine("stop song.....(Gaana)");
		}

        public void Stop()
        {
			WriteLine("stop song.....(Gaana TM.)");
		}
    }
}
