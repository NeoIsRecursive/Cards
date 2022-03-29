
public class Deck
{
	public List<Card> Cards;

	public char[] cardTypes = new char[] {
        'A',
        'K',
        'Q',
        'J',
        'X',
        '9',
        '8',
        '7',
        '6',
        '5',
        '4',
        '3',
        '2',
    };

    public int[] cardValues = new int[] {
        11,
        10,
        10,
        10,
        10,
        9,
        8,
        7,
        6,
        5,
        4,
        3,
        2
    };

    public string[] cardColors = new string[]
    {
        "spade",
        "hearts",
        "clubs",
        "diamonds"
    };
    int decks;
    public Deck(int decks)
	{
        if (decks < 1) decks = 1;
        this.decks = decks;
	}
    public void PrepareDeck()
    {
        this.Cards = this.Fill(decks);
        this.Cards = this.Shuffle();
    }
	public List<Card> Fill(int decks)
    {
        var cards = new List<Card>();
        for (int i = 0; i < decks; i++)
        {
            foreach (var color in cardColors)
            {
                var j = 0;
                foreach (var type in cardTypes)
                {
                    cards.Add(new Card(type, cardValues[j++], color));
                }
            }
        }
        Console.WriteLine("there are " +cards.Count() + " cards in the deck");
        return cards;
    }

    public List<Card> Shuffle()
    {
        var random = new Random();
        return this.Cards.OrderBy(a => random.Next()).ToList();
    }

    public Card Draw()
    {
        var card = this.Cards.Last<Card>(); 
        this.Cards.Remove(card);
        return card;
    }
}

