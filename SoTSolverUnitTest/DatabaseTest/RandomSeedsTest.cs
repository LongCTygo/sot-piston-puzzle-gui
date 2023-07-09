using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.DataAccess;
using SoTSolverClassLibrary.Puzzle;
using SoTSolverClassLibrary.Solver;

namespace SoTSolverUnitTest.DatabaseTest
{
    internal class RandomSeedsTest
    {
        private SeedDAO seedDAO, seededDAO;
        [SetUp]
        public void Setup()
        {
            seedDAO = new SeedDAO();
            seededDAO = new SeedDAO(0);
        }

        [Test]
        public void UnitTest_1()
        {
            Assert.Throws<ArgumentException>((() => seedDAO.GetRandomSeeds(0, 20, true, -1)));
        }

        [Test]
        public void UnitTest_2()
        {
            Assert.Throws<ArgumentException>((() => seedDAO.GetRandomSeeds(0, 20, true, 0)));
        }

        [Test]
        public void UnitTest_3()
        {
            int amount = 1;
            var randomSeeds = seedDAO.GetRandomSeeds(0, 20, true, amount);
            Assert.AreEqual(amount,randomSeeds.Count);
        }

        [Test]
        public void UnitTest_4()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(0, 0, true, 1);
            Assert.IsFalse(randomSeeds.Any());
        }

        [Test]
        public void UnitTest_5()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(1, 0, true, 1);
            Assert.IsFalse(randomSeeds.Any());
        }

        [Test]
        public void UnitTest_6()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(20, 20, true, 1);
            Assert.IsFalse(randomSeeds.Any());
        }

        [Test]
        public void UnitTest_7()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(19, 19, true, 100);
            Assert.AreEqual(38, randomSeeds.Count);
        }

        [Test]
        public void UnitTest_8()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(5, 7, true, 5);
            foreach (Seed seed in randomSeeds)
            {
                SolutionTree tree = new SolutionTree(new BoardNode(new Board(seed)));
                var node = tree.SolveBreadthFirst();
                Assert.AreEqual(node.GetDepth(),seed.MovesRequired);
            }
        }

        [Test]
        public void UnitTest_9()
        {
            var randomSeeds = seededDAO.GetRandomSeeds(0, 20, true, 1);
            Assert.AreEqual(randomSeeds[0].SeedValue, 1719612);
        }

        [Test]
        [Repeat(10)]
        public void UnitTest_10()
        {
            var randomSeeds = seedDAO.GetRandomSeeds(0, 20, false, 1);
            Board b = new Board(randomSeeds[0]);
            Assert.IsFalse(b.IsObstructed());
        }

    }
}
