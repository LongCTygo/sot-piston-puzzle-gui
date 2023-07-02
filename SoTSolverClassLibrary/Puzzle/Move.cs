using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.Puzzle
{
    public class Move
    {
        public const int Up = -1;
        public const int Down = 1;
        public const int Right = 2;
        public const int Left = -2;
        public static readonly string[] Columns = {"A","B","C","D"};
        public readonly int Dir;
        public readonly int Slot;

        public Move(int dir, int slot)
        {
            Dir = dir;
            Slot = slot;
        }

        public override string ToString()
        {
            switch (Dir)
            {
                case Up:
                    return Columns[Slot] + " Up";
                case Down:
                    return Columns[Slot] + " Down";
                case Right:
                    return $"{4 - Slot} Right";
                case Left:
                    return $"{4 - Slot} Left";
            }
            return "??";
        }

    }
}
