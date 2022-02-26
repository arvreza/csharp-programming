using System.Collections.Generic;
public class InstrumentedList 
{
    private List<string> list = new List<string>();
    private int counter = 0;

    public string this[int index]
    {
        get 
        { 
            return list[0]; 
        }
    }
    public int AddCounter 
    { 
        get
        {
            return counter;
        } 
    }

    public int Count 
    { 
        get 
        {
            return list.Count;
        } 
    }

    public void Add(string value)
    {
        ++counter;
        list.Add(value);
    }

    public void RemoveAt(int index)
    {
        list.RemoveAt(index);
    }
}