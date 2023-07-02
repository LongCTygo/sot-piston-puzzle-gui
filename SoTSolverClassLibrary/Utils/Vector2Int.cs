using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.Utils
{
    public class Vector2Int
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Constructors
        public Vector2Int()
        {
            Setup(0, 0);
        }
        public Vector2Int(Vector2Int vector)
        {
            Setup(vector.X, vector.Y);
        }
        public Vector2Int(int x, int y)
        {
            Setup(x, y);
        }


        //Setup
        private void Setup(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void LeftRotateBoard()
        {
            float nx = X - 1.5F;
            float ny = Y - 1.5F;
            X = (int)(-ny + 1.5F);
            Y = (int)(nx + 1.5F);
        }

        public void FullRotateBoard()
        {
            X = 3 - X;
            Y = 3 - Y;
        }

        public void RightRotateBoard()
        {
            float nx = X - 1.5F;
            float ny = Y - 1.5F;
            X = (int)(ny + 1.5F);
            Y = (int)(-nx + 1.5F);
        }

        public bool IsMatching(int location)
        {
            return (4 * X + Y) == location;
        }

        public double GetDistance(Vector2Int other)
        {
            Vector2Int v = this.Minus(other);
            return v.Length();
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        private Vector2Int Minus(Vector2Int other)
        {
            return new Vector2Int(X - other.X, Y - other.Y);
        }
    }
}
