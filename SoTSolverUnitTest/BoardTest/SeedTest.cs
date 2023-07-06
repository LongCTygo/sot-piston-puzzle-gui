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
        public void UnitTest_1()
        {
            Assert.Throws<ArgumentException>((() => new Board(-10)));
        }

        [Test]
        public void UnitTest_2()
        {
            Assert.Throws<ArgumentException>((() => new Board(-1)));
        }

        [Test]
        public void UnitTest_3()
        {
            int seed = 0;
            Board b  = new Board(seed);
            Assert.AreEqual(seed,b.Seed);
        }

        [Test]
        public void UnitTest_4()
        {
            int seed = 8388607;
            Board b = new Board(seed);
            Assert.AreEqual(seed, b.Seed);
        }

        [Test]
        public void UnitTest_5()
        {
            Assert.Throws<ArgumentException>((() => new Board(8388608)));
        }
    }
}