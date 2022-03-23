public class Card
{
    public char Type { get; }
    public string Color { get; }
    //if fat make ace value 1
    public int Value { get; set; }


    public Card(char type, int value, string color)
    {
        this.Type = type;
        this.Value = value;
        this.Color = color;
    }
}

