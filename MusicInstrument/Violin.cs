using System;
public class Violin : IInstrument
{
    public void Play(Note note)
    {
        Console.WriteLine($"Violin plays {note}");
    }

    public void AddInterval(int interval)
    {
        
    }

}