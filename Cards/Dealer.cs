public class Dealer : BasePlayer
{
    public Dealer()
    {
        this.Name = "Dealer";
    }

    private Deck deck = new Deck();

    public Card Deal()
    {
        return this.deck.Draw();
    }

    public bool MustStay()
    {
        return this.Total >= 17;
    }
}

