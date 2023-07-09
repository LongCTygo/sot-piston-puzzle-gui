using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.Puzzle;

namespace SoTSolverClassLibrary.Solver
{
    public class BoardNode
    {
        public static readonly double SmartLimit = 1.5;
        public List<BoardNode?> Children { get; set; } = new List<BoardNode?>();
        public Board Board { get; set; }
        public BoardNode? ParentNode { get; set; }

        public BoardNode()
        {
            Board = new Board(0);
        }

        public BoardNode(Board board)
        {
            Board = board;
        }

        public BoardNode(Board board, BoardNode parentNode)
        {
            Board = board;
            ParentNode = parentNode;
        }

        private void AddTop(Board p)
        {
            Children.Insert(0, new BoardNode(p, this));
        }

        private void AddLast(Board p)
        {
            Children.Add(new BoardNode(p, this));
        }

        public int GetDepth()
        {
            int depth = 0;
            BoardNode p = this;
            while (p.ParentNode != null)
            {
                p = p.ParentNode;
                depth++;
            }
            return depth;
        }

        public void CreateChildren(bool ignoreBadMoves)
        {
            Board p;
            double distance = Board.GetDistance();
            for (int i = 0; i < 4; i++)
            {
                //Down
                if (Board.LastMove == null || Board.LastMove.Dir != Move.Up
                                           || Board.LastMove.Slot != i)
                {
                    p = Board.MoveDown(i);
                    if (p != null)
                    {
                        double pDis = p.GetDistance();
                        if (pDis < distance || pDis < SmartLimit)
                        {
                            AddTop(p);
                        }
                        else if (pDis == distance || ignoreBadMoves)
                        {
                            AddLast(p);
                        }
                    }
                }
                //Up
                if (Board.LastMove == null || Board.LastMove.Dir != Move.Down
                        || Board.LastMove.Slot != i)
                {
                    p = Board.MoveUp(i);
                    if (p != null)
                    {
                        double pDis = p.GetDistance();
                        if (pDis < distance || pDis < SmartLimit)
                        {
                            AddTop(p);
                        }
                        else if (pDis == distance || ignoreBadMoves)
                        {
                            AddLast(p);
                        }
                    }
                }
                //Right
                if (Board.LastMove == null || Board.LastMove.Dir != Move.Left 
                                           || Board.LastMove.Slot != i)
                {
                    p = Board.MoveRight(i);
                    if (p != null)
                    {
                        double pDis = p.GetDistance();
                        if (pDis < distance || pDis < SmartLimit)
                        {
                            AddTop(p);
                        }
                        else if (pDis == distance || ignoreBadMoves)
                        {
                            AddLast(p);
                        }
                    }
                }
                //Left
                if (Board.LastMove == null || Board.LastMove.Dir != Move.Right
                                           || Board.LastMove.Slot != i)
                {
                    p = Board.MoveLeft(i);
                    if (p != null)
                    {
                        double pDis = p.GetDistance();
                        if (pDis < distance || pDis < SmartLimit)
                        {
                            AddTop(p);
                        }
                        else if (pDis == distance || ignoreBadMoves)
                        {
                            AddLast(p);
                        }
                    }
                }
            }
        }

        public int BreadthSolve(int maxDepth, int depth, double dist)
        {
            if (depth >= maxDepth)
            {
                return -2; //Quit
            }
            else if (dist == 0)
            {
                return depth; // Found best
            }
            else
            {
                return -1; // Continue
            }
        }

        public BindingList<Solution> GetSolutions()
        {
            BindingList<Solution> solutions = new BindingList<Solution>();
            BoardNode? p = this;
            while (p != null)
            {
                if (p.Board.LastMove != null)
                {
                    solutions.Insert(0, new Solution(p.Board.LastMove));
                }
                p = p.ParentNode;
            }
            return solutions;
        }
    }
}
