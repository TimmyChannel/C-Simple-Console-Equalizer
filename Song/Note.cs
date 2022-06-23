using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public enum Tone
    {
        T0 = 0,
        T247 = 247,
        T264 = 264,
        T300 = 300,
        T329 = 329,
        T330 = 330,
        T352 = 352,
        T392 = 392,
        T415 = 415,
        T417 = 417,
        T440 = 440,
        T466 = 466,
        T494 = 494,
        T523 = 523,
        T587 = 587,
        T622 = 622,
        T659 = 659,
        T698 = 698,
        T740 = 740,
        T783 = 783,
        T784 = 784,
        T880 = 880,
        T932 = 932,
    }


    public enum Duration
    {
        D1200 = 1200,
        D1000 = 1000,
        D800 = 800,
        D600 = 600,
        D500 = 500,
        D300 = 300,
        D250 = 250,
        D150 = 150,
        D125 = 125,
        D120 = 120,
        D100 = 100,
    }
    public class Note
    {
        private Tone toneVal;
        private Duration durVal;
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }
        public Note(Duration time)
        {
            toneVal = 0;
            durVal = time;
        }
        
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
        public override string ToString()
        {
            return $"Tone: {toneVal} Durration: {durVal}";
        }
    }
}
