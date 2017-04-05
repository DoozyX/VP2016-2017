using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1 {
    abstract class Game {
        protected Grid grid;
        public int CurrentGeneration { get; set; }
        public int MaxGenerations { get; set; }

        public Game(int maxGenerations) {
            // vasiot kod ovde
            MaxGenerations = maxGenerations;
            CurrentGeneration = 0;
        }

        public void Evolve() {
            // vasiot kod ovde
            grid.Evolve();
            CurrentGeneration++;
        }

        virtual public void Show() {
            Console.Clear();
            // vasiot kod ovde
            // prikazot od pechatenjeto treba da e sleden:
            // 'Current generation: <CurrentGeneration>'
            // ' _ _ _ X _ _ _

            // ' _ _ _ X _ _ _

            // itn
            Console.WriteLine("Current generation: {0}", CurrentGeneration);
            foreach (Cell[] cellRow in grid.Cells) {
                foreach (Cell cell in cellRow) {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }
        }
    }
}