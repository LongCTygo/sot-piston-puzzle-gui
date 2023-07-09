using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.Puzzle;
using SoTSolverClassLibrary.Solver;

namespace SoTSolverUnitTest.BoardTest
{
    public class SolverTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UnitTest_1()
        {
            SolutionTree st = new SolutionTree(new BoardNode(new Board(543728)));
            var node = st.SolveBreadthFirst();
            Assert.AreEqual(5,node.GetDepth());
        }

        [Test]
        public void UnitTest_2()
        {
            SolutionTree st = new SolutionTree(new BoardNode(new Board(0)));
            var node = st.SolveBreadthFirst();
            Assert.IsNull(node);
        }
        //B Up 1 Right B Up 
        [Test]
        public void UnitTest_3()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst();
            var list = node.GetSolutions();
            Assert.AreEqual(list.Count,3);
            Assert.AreEqual(list[0].Move,"B Up");
            Assert.AreEqual(list[1].Move, "1 Right");
            Assert.AreEqual(list[2].Move, "B Up");
        }
        //2 Right
        [Test]
        public void UnitTest_4()
        {
            Board board = new Board(9);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst();
            var list = node.GetSolutions();
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(list[0].Move, "2 Right");
        }

        [Test]
        public void UnitTest_5()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst(-1);
            Assert.IsNull(node);
        }

        [Test]
        public void UnitTest_6()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst(0);
            Assert.IsNull(node);
        }

        [Test]
        public void UnitTest_7()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst(1);
            Assert.IsNull(node);
        }

        [Test]
        public void UnitTest_8()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst(2);
            Assert.IsNull(node);
        }

        [Test]
        public void UnitTest_9()
        {
            Board board = new Board(1572933);
            SolutionTree st = new SolutionTree(new BoardNode(board));
            var node = st.SolveBreadthFirst(3);
            var list = node.GetSolutions();
            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list[0].Move, "B Up");
            Assert.AreEqual(list[1].Move, "1 Right");
            Assert.AreEqual(list[2].Move, "B Up");
        }
    }
}
