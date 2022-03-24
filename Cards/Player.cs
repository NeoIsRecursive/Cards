public class Player : BasePlayer
{
    //public new bool Stay = false;
    public Player (string name)
    {
        this.Name = name;
    }

    public void WantsToStay(string answer)
    {
        if (answer is null) answer = "no";
        var stay = answer == "yes" || answer == "y";
        this.Stay = stay;
    }
}
