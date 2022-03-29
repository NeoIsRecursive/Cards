public class BasePlayer
{
    public List<Card> Hand = new List<Card>();
    public string Name;
    public bool Bust = false;
    public bool Stay = false;
    public int Total;
    public int Max = 21;

    public void RecieveCard(Card card, bool silent = false)
    {
        if (!silent)
        { 
            Console.WriteLine($"{this.Name} got {card.Type}");
        }

        this.Hand.Add(card);
   
        if (this.Total + card.Value > 21)
        {
            this.HandleAce(card.Value);
        }

        this.Total = this.CalculateHand();
    }

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

    public void HandleAce(int newCard)
    {
        var totalWithNewCard = this.Total + newCard;
        foreach (var card in this.Hand)
        {
            if (card.Type == 'A' && totalWithNewCard > 21)
            {
                if (card.Value == 1) continue;

                card.Value = 1;
                totalWithNewCard -= 10;
            }
        }
    }

    public void Reset()
    {
        this.Hand.Clear();
        this.Stay = false;
        this.Bust = false;
    }
}
