var players = new List<Player>();


Console.WriteLine("welcome to Henriks Casino");
Console.WriteLine("-------------------------");
Console.Write("how many players?:");
var input = Console.ReadLine();
if (input == "" || Convert.ToInt16(input) < 1)
{
    Console.WriteLine("no players no play");
    return;
}
int amountOfPLayers = Convert.ToInt16(input);

for (int i = 0; i < amountOfPLayers; i++)
{
    Console.Write($"player {i+1}'s name: ");
    var name = Console.ReadLine();
    name = name is null || name == "" ? "player"+(i+1) : name ;
    players.Add(new Player(name));
    Console.WriteLine(players[i].Name);
}

Console.Write("how many decks?:");
input = Console.ReadLine();

var amountOfDecks = Convert.ToInt16(input == ""? null : input);
var dealer = new Dealer(amountOfDecks);

var blackjack = new Blackjack(dealer, players);

var play = true;

while (play)
{
    Console.Clear();
    blackjack.Play();
    Console.Write("another round?[y/n] ");
    input = Console.ReadLine();
    play = input == "y" || input == "yes" ? true : false;
}

Console.WriteLine("Thanks for playing!");