
public class Blackjack
{
    public Dealer _dealer;
    public List<Player> _players;

    public Blackjack(Dealer dealer, List<Player> players)
    {
        this._dealer = dealer;
        this._players = players;
        this._dealer.Deal(_dealer, true);

        this.Init();
    }

    public void Init()
    {
        foreach (var player in this._players)
        {
            for (int i = 0; i < 2; i++)
            {
                this._dealer.Deal(player, true);
            }

            //player.RecieveCard(new Card('A', 11, "spade"), true);
            //player.RecieveCard(new Card('5', 5, "spade"), true);
        }

        this.CardsOnTable();
    }

    public void Turn(Dealer dealer, Player player)
    {
        while (!player.Bust && !player.Stay)
        {
            if (!player.Bust)
            {
                Console.WriteLine("want to stay?");
                player.WantsToStay(Console.ReadLine());
            }

            if (!player.Bust && !player.Stay)
            {
                dealer.Deal(player);
                if (player.Total == 21)
                {
                    Console.WriteLine($"{player.Name}, winner winner chicken dinner!");
                    break;
                } else {
                    Console.WriteLine($"Total: {player.Total}");
                }
            }

            if (player.Bust)
            {
                Console.WriteLine($"{player.Name}'s bust!");
            }
        }

    }

    public void PlayerTurns()
    {
        foreach (var player in _players)
        {
            Console.Write($"ready for {player.Name}s turn? press any button to start turn");
            Console.ReadKey();
            Console.Clear();
            this.CardsOnTable();

            if (player.Total == 21)
            {
                Console.WriteLine($"{player.Name}, winner winner chicken dinner!");
            }
            else
            {

                this.Turn(this._dealer, player);
            }
        }
    }

    public void CardsOnTable()
    {
        Console.WriteLine($"{_dealer.Name}: {_dealer.GetHand()}");
        foreach (var player in _players)
        {
            Console.WriteLine($"{player.Name}: {player.GetHand()}");
        }
    }

    public void Play()
    {
        this.PlayerTurns();
        this.DealerTurns();

        foreach (var player in _players)
        {
            bool winner = true;

            if (player.Bust)
            {
                winner = false;
            }

            if (player.Total < _dealer.Total && !_dealer.Bust)
            {
                winner = false;
            }

            if (winner)
            {
                Console.WriteLine($"{player.Name} won!");
            } else
            {
                Console.WriteLine($"Dealer won over {player.Name} :(");
            }
        }
    }

    public void DealerTurns()
    {
        while(_dealer.Total < 17)
        {
            _dealer.Deal(_dealer);

            Console.WriteLine($"{_dealer.Total}");
        }
    }
}

