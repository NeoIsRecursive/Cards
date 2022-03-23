public class BasePlayer
{
    public List<Card> Hand = new List<Card>();
    public string Name;
    public bool Bust = false;
    public bool Stay = false;
    public int Total;
    public int Max = 21;

    public void RecieveCard(Card card)
    {
        if (card.Type == 'A' && this.Total + 11 > 21)
        {
            card.Value = 1;
        }

        Console.WriteLine($"{this.Name} got {card.Type}");

        this.Hand.Add(card);

        this.Total = this.CalculateHand();

        Console.WriteLine($"Total: {this.Total}");
    }

    public int CalculateHand()
    {
        var total = 0;

        foreach (Card card in this.Hand)
        {
            total += card.Value;

        }

        if (this.Total > this.Max)
        {
            this.Bust = true;
        }

        return total;
    }
}
