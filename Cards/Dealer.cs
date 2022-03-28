public class Dealer : BasePlayer
{
    public Dealer()
    {
        this.Name = "Dealer";
    }

    private Deck deck = new Deck();

    public void Deal(BasePlayer player, bool silent = false)
    {
         player.RecieveCard(this.deck.Draw(), silent);
    }
}

