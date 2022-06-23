using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Song
{
    public class Song
    {
        public string SongName { get; private set; }
        public Note[] Notes { get; private set; }
        private Equalizer equalizer;
        public Song(string name, Note[] notes)
        {
            SongName = name;
            Notes = notes;
            equalizer = new Equalizer(this);
        }
        public void PlaySong()
        {
            foreach (var note in Notes)
            {
                if (note.NoteTone == 0) Thread.Sleep((int)note.NoteDuration);
                else
                {
                    Console.Beep((int)note.NoteTone, (int)note.NoteDuration);
                    equalizer.GetMagic(note);
                }
                if (Console.KeyAvailable) return;
            }

        }
    }
}
