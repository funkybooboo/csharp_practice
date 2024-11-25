namespace HelloWorldCS;

class Program
{
    public static void Main(string[] args)
    {
        var game = new GuessingGame(1, 100);
        game.Run();
    }
}
