﻿
public class Blackjack
{
	public Dealer _dealer;
	public List<Player> _players;

	public Blackjack(Dealer dealer, List<Player> players)
	{
		this._dealer = dealer;
		this._players = players;
        this._dealer.Deal(_dealer);

        this.Init();
	}

    public void Init()
    {
        foreach (var player in this._players)
        {
            for (int i = 0; i < 2; i++)
            {
                this._dealer.Deal(player);
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
			_dealer.Turn(player);

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
}
