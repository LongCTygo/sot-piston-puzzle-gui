using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.Solver
{
    public class SolutionTree
    {
        public BoardNode? Root { get; set; }

        public SolutionTree(BoardNode? root)
        {
            Root = root;
        }


        public BoardNode? SolveBreadthFirst(int maxDepth, int maxSearch, bool ignoreBadMoves)
        {
            Queue<BoardNode?> queue = new Queue<BoardNode?>();
            List<double> bestDist = new List<double>();

            bestDist.Add(Root.Board.GetDistance());
            int currentDepth = 0;
            int currentProcess = 0;
            queue.Enqueue(Root);
            while (queue.Any())
            {
                BoardNode? p = queue.Dequeue();
                currentProcess++;
                if (currentProcess > maxSearch)
                {
                    return null;
                }
                int depthP = p.GetDepth();
                double distP = p.Board.GetDistance();
                if (depthP != currentDepth)
                {
                    currentDepth = depthP;
                    bestDist.Add(distP);
                }
                else if (distP < bestDist[depthP])
                {
                    bestDist[depthP] = distP;
                }
                int result = p.BreadthSolve(maxDepth, depthP, distP);
                if (result == -2)
                {
                    break;
                }
                else if (result == -1)
                {
                    p.CreateChildren(ignoreBadMoves);
                    foreach (BoardNode? c in p.Children)
                    {
                        if (depthP <= 3 || c.Board.GetDistance() < bestDist[depthP - 4])
                        {
                            queue.Enqueue(c);
                        }
                    }
                    //De-referencing children nodes
                    p.Children.Clear();
                }
                else
                {
                    return p;
                }
            }
            return null;
        }

        public BoardNode? SolveBreadthFirst()
        {
            return SolveBreadthFirst(20, 10000000, true);
        }

        public BoardNode? SolveBreadthFirst(int maxDepth)
        {
            return SolveBreadthFirst(maxDepth, 10000000, true);
        }
    }
}
