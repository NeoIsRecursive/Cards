public class Dealer : BasePlayer
{
    public Dealer(int decks = 1)
    {
        this.Name = "Dealer";
        this.deck = new Deck(decks);
    }

    private Deck deck;

    public void Deal(BasePlayer player, bool silent = false)
    {
         player.RecieveCard(this.deck.Draw(), silent);
    }

    public void PrepareDeck()
    {
        this.deck.PrepareDeck();
    }
}

