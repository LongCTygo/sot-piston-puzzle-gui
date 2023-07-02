using SoTSolverClassLibrary.Puzzle;

namespace SoTSolverUnitTest.BoardTest
{
    public class SeedTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Board board = new Board(1234);
            Assert.AreEqual(1234,board.GetSeed());
        }
    }
}