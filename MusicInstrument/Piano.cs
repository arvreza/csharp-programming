using System;
public class Piano : IInstrument
{
    public void Play(Note note)
    {
        Console.WriteLine($"Piano plays {note}");
    }

    public void AddInterval(int interval)
    {
        
    }
}