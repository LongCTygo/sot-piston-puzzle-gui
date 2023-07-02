using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.Utils;

namespace SoTSolverClassLibrary.Puzzle
{
    public class Board
    {
        public static readonly int MIN_SEED = 0;
        public static readonly int MAX_SEED = 8388607;
        public static readonly int MAX_NORMAL_SEED = 8388607;

        public int[,] BoardArray = new int[4,4];
        public Move? LastMove { get; set; }
        public Vector2Int Goal { get; set; }

        private int seed = -1;
        public int Seed
        {
            get
            {
                if (seed == -1)
                {
                    seed = GetSeed();
                }
                return seed;
            }
        }

        //Constructors
        public Board()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    BoardArray[x,y] = 0;
                }
            }
            this.Goal = new Vector2Int();
        }

        public Board(int[,] boardArray, Vector2Int goal, Move? lastMove)
        {
            Setup(boardArray, lastMove, goal);
        }

        public Board(int[,] boardArray, Vector2Int goal)
        {
            Setup(boardArray, null, goal);
        }

        public Board(int seed)
        {
            ParseSeed(seed);
            this.seed = seed;
        }

        private Board(int[,] boardArray, Vector2Int goal, int dir, int slot)
        {
            BoardArray = boardArray;
            Goal = goal;
            LastMove = new Move(dir, slot);
        }

        //Setup

        private void Setup(int[,] boardArray, Move? lastMove, Vector2Int goal)
        {
            BoardArray = boardArray;
            LastMove = lastMove;
            Goal = goal;
        }

        //Method

        private void ParseSeed(int seed)
        {
            if (seed < MIN_SEED || seed > MAX_SEED)
            {
                throw new ArgumentException(
                    $"Seed '{seed}' is not a valid seed, must be between {MIN_SEED} and {MAX_SEED}.");
            }
            int[] bitArray = BaseConversionUtil.ToBinaryArray(seed);
            //first 9 bits are ignored
            // 9-10 Rotation value
            int rotationValue = bitArray[9] * 2 + bitArray[10];
            // 11-12 Player Position
            int px = bitArray[11] + 2;
            int py = bitArray[12];
            BoardArray[px,py] = 2;
            // 13 - 27 Board
            int k = 13;
            for (int x = 0; x < 4; x++)
            {
                bool rowOfPlayer = (px == x);
                for (int y = 0; y < 4; y++)
                {
                    if (rowOfPlayer && py == y)
                    {
                        continue;
                    }
                    BoardArray[x,y] = bitArray[k];
                    k++;
                }
            }
            //28-31 Goal
            int gx = bitArray[28] * 2 + bitArray[29];
            int gy = bitArray[30] * 2 + bitArray[31];
            Goal = new Vector2Int(gx, gy);
            // Rotate
            switch (rotationValue)
            {
                case 1:
                    RightRotate();
                    break;
                case 2:
                    Rotate180();
                    break;
                case 3:
                    LeftRotate();
                    break;
            }
        }

        public int GetSeed()
        {
            Vector2Int go = new Vector2Int(Goal);
            int seed = 0;
            // 0 ignored
            // 1-2 rotation value
            int rotationalValue = GetRotationalValue();
            seed += (int) System.Math.Pow(2, 21) * rotationalValue;
            // Rotate player back to III
            int[,] bo = null;
            switch (rotationalValue)
            {
                case 0:
                    bo = CopyOfBoard();
                    break;
                case 1:
                    bo = LeftR();
                    go.LeftRotateBoard();
                    break;
                case 2:
                    bo = FullR();
                    go.FullRotateBoard();
                    break;
                case 3: 
                    bo = RightR();
                    go.RightRotateBoard();
                    break;
                }
            // 3-4 player location
            int px = -1;
            int py = -1;
            // 5 - 19 board
            int k = 18;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (bo[x,y] == 2)
                    {
                        px = x;
                        py = y;
                    }
                    else
                    {
                        seed += (int) Math.Pow(2, k) * bo[x,y];
                        k--;
                    }
                }
            }
            // throws InvalidOperationException if board does not contain player, or multiple players
            if (px == -1 && py == -1)
            {
                throw new InvalidOperationException("The board does not have a player.\n" + this);
            }
            if (k != 3)
            {
                throw new InvalidOperationException("The board has more than one player.\n" + this);
            }
            seed += (int)Math.Pow(2, 20) * (px - 2)
                    + (int)Math.Pow(2, 19) * (py);
            // 20 - 23 goal
            seed += 4 * go.X;
            seed += 1 * go.Y;
            //Seed
            return seed;
        }

        private int[,] LeftR()
        {
            int[,] newBoard = new int[4,4];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    newBoard[x,y] = BoardArray[y,3 - x];
                }
            }
            return newBoard;
        }

        private int[,] FullR()
        {
            int[,] newBoard = new int[4,4];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    newBoard[x,y] = BoardArray[3 - x,3 - y];
                }
            }
            return newBoard;
        }

        private int[,] RightR()
        {
            int[,] newBoard = new int[4,4];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    newBoard[x,y] = BoardArray[3 - y,x];
                }
            }
            return newBoard;
        }

        private int[,] CopyOfBoard()
        {
            int[,] b = new int[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[i,j] = BoardArray[i,j];
                }
            }

            return b;
        }

        private void LeftRotate()
        {
            BoardArray = LeftR();
            Goal.LeftRotateBoard();
        }

        private void Rotate180()
        {
            BoardArray = FullR();
            Goal = new Vector2Int(3 - Goal.X, 3 - Goal.Y);
        }

        private void RightRotate()
        {
            BoardArray = RightR();
            Goal.RightRotateBoard();
        }

        public int GetRotationalValue()
        {
            Vector2Int player = GetPlayerPosition();
            if (player.X < 2)
            {
                if (player.Y < 2)
                {
                    return 1;
                }
                return 2;
            }
            else if (player.Y < 2)
            {
                return 0;
            }
            return 3;
        }

        private Vector2Int? GetPlayerPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (BoardArray[i,j] == 2)
                    {
                        return new Vector2Int(i, j);
                    }
                }
            }
            return null;
        }

        public bool IsGoalCovered()
        {
            return BoardArray[Goal.X,Goal.Y] != 0;
        }

        public int GetCoalCount()
        {
            int coal = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (BoardArray[i,j] == 1)
                    {
                        coal++;
                    }
                }
            }
            return coal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                int x = i / 4;
                int y = i % 4;
                // If goal
                if (Goal.IsMatching(i))
                {
                    if (BoardArray[x,y] == 0)
                    {
                        // unoccupied
                        sb.Append("x ");
                    }
                    else
                    {
                        // Occupied
                        sb.Append("# ");
                    }
                }
                else if (BoardArray[x,y] == 0)
                {
                    sb.Append(". ");
                }
                else if (BoardArray[x,y] == 1)
                {
                    sb.Append("o ");
                }
                else if (BoardArray[x,y] == 2)
                {
                    sb.Append("@ ");
                }
                else
                {
                    sb.Append("? ");
                }
                if (y == 3)
                {
                    sb.Append('\n');
                }
            }
            return sb.ToString();
        }

        public double GetDistance()
        {
            Vector2Int player = GetPlayerPosition();
            return player.GetDistance(Goal);
        }

        public Board? MoveDown(int y)
        {
            // Useless push
            if (BoardArray[0,y] == 0)
            {
                return null;
            }
            int x = 1;
            int t = -1;
            for (; x < 4; x++)
            {
                if (BoardArray[x,y] == 0)
                {
                    t = x;
                    break;
                }
            }
            // Can't push
            if (t == -1)
            {
                return null;
            }
            // Copy
            int[,] copyOfBoard = CopyOfBoard();
            // Swap
            for (; t > 0; t--)
            {
                copyOfBoard[t,y] = copyOfBoard[t - 1,y];
            }
            copyOfBoard[0,y] = 0;
            Board newBoard = new Board(copyOfBoard, Goal, Move.Down, y);
            return newBoard;
        }

        public Board? MoveUp(int y)
        {
            // Useless push
            if (BoardArray[3,y] == 0)
            {
                return null;
            }
            int x = 2;
            int t = -1;
            for (; x >= 0; x--)
            {
                if (BoardArray[x,y] == 0)
                {
                    t = x;
                    break;
                }
            }
            // Can't push
            if (t == -1)
            {
                return null;
            }
            // Copy
            int[,] copyOfBoard = CopyOfBoard();
            // Swap
            for (; t < 3; t++)
            {
                copyOfBoard[t,y] = copyOfBoard[t + 1,y];
            }
            copyOfBoard[3,y] = 0;
            Board newBoard = new Board(copyOfBoard, Goal, Move.Up, y);
            return newBoard;
        }

        public Board? MoveRight(int x)
        {
            // Useless push
            if (BoardArray[x,0] == 0)
            {
                return null;
            }
            int y = 1;
            int t = -1;
            for (; y < 4; y++)
            {
                if (BoardArray[x,y] == 0)
                {
                    t = y;
                    break;
                }
            }
            // Can't push
            if (t == -1)
            {
                return null;
            }
            // Copy
            int[,] copyOfBoard = CopyOfBoard();
            // Swap
            for (; t > 0; t--)
            {
                copyOfBoard[x,t] = copyOfBoard[x,t - 1];
            }
            copyOfBoard[x,0] = 0;
            Board newBoard = new Board(copyOfBoard, Goal, Move.Right, x);
            return newBoard;
        }

        public Board? MoveLeft(int x)
        {
            // Useless push
            if (BoardArray[x,3] == 0)
            {
                return null;
            }
            int y = 2;
            int t = -1;
            for (; y >= 0; y--)
            {
                if (BoardArray[x,y] == 0)
                {
                    t = y;
                    break;
                }
            }
            // Can't push
            if (t == -1)
            {
                return null;
            }
            // Copy
            int[,] copyOfBoard = CopyOfBoard();
            // Swap
            for (; t < 3; t++)
            {
                copyOfBoard[x,t] = copyOfBoard[x,t + 1];
            }
            copyOfBoard[x,3] = 0;
            Board newBoard = new Board(copyOfBoard, Goal, Move.Left, x);
            return newBoard;
        }
    }
}   
