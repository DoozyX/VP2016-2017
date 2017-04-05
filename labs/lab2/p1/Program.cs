using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace p1 {
    class Program {
        static readonly int MAX_GENERATIONS = 10;

        static void Main(string[] args) {
            // Instanciranje na objekt od igrata
            Game game = new OscilatorGame(OscilatorGame.GameType.Pulsar, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations) {
                game.Show();
                game.Evolve();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}