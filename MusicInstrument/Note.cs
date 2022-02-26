
public class Note
{
    public readonly Syllables Syllables;
    public readonly Shift Shift;

    public Note (Syllables syllables, Shift shift) => (Syllables, Shift) = (syllables, shift);

    public override string ToString()
    {
        string s = (Shift == Shift.Sharp? "#": "b");
        return $"{Syllables}{s}";
    }
}
