var deck = new Deck();


foreach (var card in deck.Cards)
{
    Console.WriteLine($"{card.Type} : {card.Color}" );
}
Console.WriteLine(deck.Cards.Count());

Console.WriteLine(deck.Draw().Type);

foreach (var card in deck.Cards)
{
    Console.WriteLine($"{card.Type} : {card.Color}");
}
Console.WriteLine(deck.Cards.Count());