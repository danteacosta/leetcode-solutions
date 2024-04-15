class StringBuilder
{
    private ArrayList<char> characters;

    public StringBuilder()
    {
        characters = new ArrayList<char>();
    }

    public void Append(string str)
    {
        foreach (char c in str)
        {
            characters.Add(c);
        }
    }

    public override string ToString()
    {
        return new string(characters.ToArray());
    }
}
