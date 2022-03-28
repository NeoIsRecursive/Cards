public class Dealer : BasePlayer
{
    public Dealer()
    {
        this.Name = "Dealer";
    }

    private Deck deck = new Deck();

    public void Deal(BasePlayer player)
    {
         player.RecieveCard(this.deck.Draw());
    }

    public bool MustStay()
    {
        return this.Total >= 17;
    }
}

