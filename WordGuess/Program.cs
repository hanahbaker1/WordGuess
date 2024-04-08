using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MultiPlayerWordGame;

namespace WordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup DI
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<IMultiplayerGuessingGame, MultiplayerGuessingGame>();
            builder.Services.AddSingleton<IVocabularyChecker, VocabularyChecker>();
            IHost host = builder.Build();

            // Resolve IMultiplayerGuessingGame from the service provider
            var multiplayerGuessingGame = host.Services.GetRequiredService<IMultiplayerGuessingGame>();

            // Use IMultiplayerGuessingGame 
            multiplayerGuessingGame.SubmitGuess("hello", "test");
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
