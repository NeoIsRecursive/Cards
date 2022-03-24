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

    public bool Turn(Player player)
    {
        while (!player.Bust && !player.Stay)
        {
            if (!player.Bust)
            {
                Console.WriteLine("want to stay?");
                player.WantsToStay(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("you are bust!");
            }

            if (!player.Bust && !player.Stay)
            {
            this.Deal(player);
            Console.WriteLine($"Total: {player.Total}");
            }

        }
        return player.Bust;
    }
}

