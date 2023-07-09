using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.Puzzle;
using SoTSolverClassLibrary.Utils;

namespace SoTSolverUnitTest.BoardTest
{
    internal class GetSeedTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UnitTest_1()
        {
            Board b = new Board(10);
            Assert.AreEqual(10, b.GetSeed());
        }

        [Test]
        public void UnitTest_2()
        {
            int[,] array =
            {
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} 
            };
            Vector2Int goal = new Vector2Int(0, 0);
            Board b = new Board(array,goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_3()
        {
            int[,] array =
            {
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(0, 0);
            Board b = new Board(array, goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_4()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = null;
            Board b = new Board(array, goal);
            Assert.Throws<NullReferenceException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_5()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(-1, 0);
            Board b = new Board(array, goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_6()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(0, -1);
            Board b = new Board(array, goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_7()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(4, 0);
            Board b = new Board(array, goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_8()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(0, 4);
            Board b = new Board(array, goal);
            Assert.Throws<InvalidOperationException>((() => b.GetSeed()));
        }

        [Test]
        public void UnitTest_9()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0}
            };
            Vector2Int goal = new Vector2Int(0, 0);
            Board b = new Board(array, goal);
            Assert.AreEqual(3145740,b.GetSeed());
        }

        [Test]
        public void UnitTest_10()
        {
            int[,] array = null;
            Vector2Int goal = new Vector2Int(0, 0);

            Assert.Throws<NullReferenceException>((() =>
            {
                Board b = new Board(array, goal);
                b.GetSeed();
            }));
        }

        [Test]
        public void UnitTest_11()
        {
            int[,] array =
            {
                {2,0,0,0} ,
                {0,0,0,0} ,
                {0,0,0,0} 
            };
            Vector2Int goal = new Vector2Int(0, 0);
            
            Assert.Throws<ArgumentException>((() =>
            {
                Board b = new Board(array, goal);
                b.GetSeed();
            }));
        }

        [Test]
        public void UnitTest_12()
        {
            int[,] array =
            {
                {0,1,1,0} ,
                {0,0,0,1} ,
                {2,0,1,1} ,
                {0,1,1,1}
            };
            Vector2Int goal = new Vector2Int(1,2);
            Board b = new Board(array, goal);
            Assert.AreEqual(199542, b.GetSeed());
        }
    }
}
