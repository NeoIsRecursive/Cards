var players = new List<Player>
    {
        new Player("Neo"),
        new Player("Patrik")
    };

var dealer = new Dealer();

var blackjack = new Blackjack(dealer, players);

blackjack.PlayerTurns();


