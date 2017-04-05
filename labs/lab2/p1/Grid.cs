using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1 {
    class Grid {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns) {
            // kod za postavuvanje na svojstvata Rows i Columns
            // ... ovde vasiot kod ...
            Rows = rows;
            Columns = columns;
            // kod za inicijalizacija na matricata
            Cells = new Cell[rows][];
            for (int i = 0; i < Rows; i++) {
                Cells[i] = new Cell[Columns];
                for (int j = 0; j < Columns; j++) {
                    // ovde kod za instanciranje na objekt od klasata Cell
                    // i postavuvanje na toj objekt na soodvetniot element vo matricata
                    // ... vasiot kod ovde...   
                    Cells[i][j] = new Cell();
                }
            }
        }

        public void ToggleCell(int x, int y, bool isAlive) {
            // vasiot kod ovde
            Cells[x][y].IsAlive = isAlive;
        }

        public void Evolve() {
            /*
            Algoritam za implementiranje na pravilata na igrata
            1. Za sekoja kletka vo matricata so kletki treba da se izbrojat brojot na
            zhivi sosedi vo 8-te nasoki (gore levo, gore sredina, gore desno, levo,
            desno, dolu levo, dolu sredina i dolu desno). 
            2. Spored slednite pravila na igrata za evolucija treba da se implementiraat
            slednite uslovi (postavuvanje na svojstvoto ShouldLive):
            - sekoja zhiva kletka so pomalku od dva zhivi sosedi umira od osamenost

            - sekoja zhiva kletka so dva ili tri zhivi sosedi prezhivuva do slednata
            generacija

            - sekoja zhiva kletka so povekje od tri sosedi umira od prenaselenost

            - sekoja mrtva kletka so tochno tri sosedi ozivuva preku reprodukcija

            3. Otkako kje gi evoluirame site kletki, treba da ja promenime nivnata
            sostojba (svojstvoto IsAlive) vo zavisnost od toa dali treba da zhivee
            (svojstvoto ShouldLive). Treba da se izminat povtorno site kletki i
            svojstvoto IsAlive da dobie vrednost na svojstvoto ShouldLive.
            */


            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++) {
                    int count = 0;
                    for (int i1 = Math.Max(0, i - 1); i1 < Math.Min(Rows, i + 2); i1++) {
                        for (int j1 = Math.Max(0, j - 1); j1 < Math.Min(Columns, j + 2); j1++) {
                            if (i1 != i || j1 != j)
                                if (Cells[i1][j1].IsAlive) {
                                    ++count;
                                }
                        }
                    }
                    if (Cells[i][j].IsAlive) {
                        if (count < 2) {
                            Cells[i][j].ShouldLive = false;
                        } else if (count == 2 || count == 3) {
                            Cells[i][j].ShouldLive = true;
                        } else {
                            Cells[i][j].ShouldLive = false;
                        }
                    } else {
                        if (count == 3) {
                            Cells[i][j].ShouldLive = true;
                        }
                    }
                }
            }

            foreach (Cell[] cellRow in Cells) {
                foreach (Cell cell in cellRow) {
                    cell.IsAlive = cell.ShouldLive;
                    cell.ShouldLive = false;
                }
            }
        }

    }
}