using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.DataAccess
{
    public class Seed
    {
        public int SeedValue { get; }
        public int MovesRequired { get; }
        public bool Obstructed { get; }

        public Seed(int seedValue, int movesRequired, bool obstructed)
        {
            SeedValue = seedValue;
            MovesRequired = movesRequired;
            Obstructed = obstructed;
        }
    }
}
