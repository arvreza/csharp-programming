using System;

namespace MusicInstrument
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayHelper(new Piano(), new Note(Syllables.C, Shift.Sharp));
            PlayHelper(new Violin(), new Note(Syllables.C, Shift.Flat));
        }

        static void PlayHelper(IInstrument instrument, Note note)
        {
            instrument.Play(note);
        }
    }
}
