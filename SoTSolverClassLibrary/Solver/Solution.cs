using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.Puzzle;

namespace SoTSolverClassLibrary.Solver
{
    public class Solution
    {
        public string Move { get; set; }
        public Solution(Move? move)
        {
            if (move == null)
            {
                Move = "Unknown? (buggy)";
            }
            else
            {
                Move = move.ToString();
            }
        }
    }
}
