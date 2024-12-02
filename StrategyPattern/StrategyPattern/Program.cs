using StrategyPattern;
using StrategyPattern.Weapons;

internal class Program
{
    private static void Main(string[] args)
    {
        Sword sword = new Sword();
        Player player = new Player(sword);
        Game game = new Game(player);
        game.Start();
    }
}

