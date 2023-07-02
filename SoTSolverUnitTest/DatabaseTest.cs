using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoTSolverClassLibrary.DataAccess;

namespace SoTSolverUnitTest
{
    internal class DatabaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SeedDAO seedDao = new SeedDAO();
            seedDao.GetRandomSeed(5);
            Assert.AreEqual(5, seedDao.GetRandomSeed(5).MovesRequired);
        }
    }
}
