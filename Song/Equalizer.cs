using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Song
{
    public class Equalizer
    {
        private Song song;
        private string field = "......................................................................................................................................";
        private string empty = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
        private Size equalizerSize = new Size(134, 20);
        private Note currentNote;
        private int dotsInNote;
        private List<int> tone = new List<int> {
                   (int)Tone.T247,
                   (int)Tone.T264,
                   (int)Tone.T300,
                   (int)Tone.T329,
                   (int)Tone.T330,
                   (int)Tone.T352,
                   (int)Tone.T392,
                   (int)Tone.T415,
                   (int)Tone.T417,
                   (int)Tone.T440,
                   (int)Tone.T466,
                   (int)Tone.T494,
                   (int)Tone.T523,
                   (int)Tone.T587,
                   (int)Tone.T622,
                   (int)Tone.T659,
                   (int)Tone.T698,
                   (int)Tone.T740,
                   (int)Tone.T783,
                   (int)Tone.T784,
                   (int)Tone.T880,
                   (int)Tone.T932
            };
        public Equalizer(Song song)
        {
            this.song = song;
            SongInfo();
            Empty();
            Console.SetWindowSize(equalizerSize.Width, equalizerSize.Height);
            dotsInNote = field.Length / 23;

        }
        private void SongInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Song Name: {song.SongName}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\t\t\t\t\t\tPress Any Key to Return");
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void Empty()
        {
            Console.WriteLine(empty);
            for (int i = 0; i < field.Length; i++)
            {
                SetColor(i);
                Console.Write('.');
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void Field()
        {
            for (int i = 0; i < field.Length; i++)
            {
                SetColor(i);
                Console.Write('.');
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void SetColor(int ind)
        {
            switch (ind)
            {
                case 0: Console.ForegroundColor = ConsoleColor.Red; break;
                case 5: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 10: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 15: Console.ForegroundColor = ConsoleColor.Green; break;
                case 20: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 25: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case 30: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case 35: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case 40: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case 45: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case 50: Console.ForegroundColor = ConsoleColor.Red; break;
                case 55: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 60: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 65: Console.ForegroundColor = ConsoleColor.Green; break;
                case 70: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 75: Console.ForegroundColor = ConsoleColor.Red; break;
                case 80: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 85: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 90: Console.ForegroundColor = ConsoleColor.Green; break;
                case 95: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 100: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case 105: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case 110: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case 115: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case 120: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case 125: Console.ForegroundColor = ConsoleColor.Red; break;
                case 130: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 135: Console.ForegroundColor = ConsoleColor.Blue; break;
            }
        }
        private void DrawNote()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var ind = tone.IndexOf((int)currentNote.NoteTone);
            var temp = ind * dotsInNote;
            var s = "";
            for (int j = 0; j < field.Length; j++)
            {
                if (j == temp)
                {
                    j += dotsInNote;
                    for (int x = 0; x < dotsInNote; x++)
                        s += '.';
                }
                else s += ' ';
            }
            SetColor(temp);
            for (int i = 0; i < empty.Length; i++)
                if (i <= 3) Console.WriteLine();
                else 
                    Console.WriteLine(s);
            Field();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GetMagic(Note note)
        {
            currentNote = note;
            SongInfo();
            if (note.NoteTone == 0) Empty();
            else DrawNote();
        }
    }
}
