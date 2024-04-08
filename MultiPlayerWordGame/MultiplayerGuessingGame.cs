
namespace MultiPlayerWordGame
{
    public class MultiplayerGuessingGame : IMultiplayerGuessingGame
    {


        IList<string> IMultiplayerGuessingGame.GetGameStrings()
        {
            throw new NotImplementedException();
        }

     

        int IMultiplayerGuessingGame.SubmitGuess(string playerName, string submission)
        {
            throw new NotImplementedException();
        }
    }
}