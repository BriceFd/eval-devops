public class GuessingGame
{
    private readonly int _secretNumber;
    public bool IsGameWon { get; private set; }

    public GuessingGame(int secretNumber)
    {
        _secretNumber = secretNumber;
        IsGameWon = false;
    }

    public string MakeGuess(int guess)
    {
        if (guess < 1 || guess > 100)
            throw new ArgumentOutOfRangeException(nameof(guess), "Le nombre doit etre entre 1 et 100.");

        if (guess == _secretNumber)
        {
            IsGameWon = true;
            return "Correct!";
        }
        else
        {
            IsGameWon = false;
            return guess < _secretNumber ? "Plus grand" : "Plus petit";
            
        }
    }
}
