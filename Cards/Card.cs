public class Card
{
    public char Type { get; }
    public string Color { get; }
    public int Value { get; set; }


    public Card(char type, int value, string color)
    {
        this.Type = type;
        this.Value = value;
        this.Color = color;
    }
}

