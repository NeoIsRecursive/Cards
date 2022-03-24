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

        //Console.WriteLine($"Total: {this.Total}");
    }

    //public bool GetWantsToStay()
    //{
    //    return this.Stay;
    //}

    public int CalculateHand()
    {
        var total = 0;

        foreach (var card in this.Hand)
        {
            total += card.Value;

        }

        if (total > this.Max)
        {
            this.Bust = true;
        }

        return total;
    }

    public string GetHand()
    {
        var hand = "";
        var count = 0;
        foreach(var card in this.Hand)
        {
            hand += card.Type + (++count < this.Hand.Count() ? ",": "");
        }
        return hand;
    }
}
