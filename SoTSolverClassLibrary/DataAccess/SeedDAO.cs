using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.DataAccess
{
    public class SeedDAO
    {
        private Random random;
        public SeedDAO()
        {
            random = new Random();
        }

        public SeedDAO(int randSeed)
        {
            random = new Random(randSeed);
        }

        public List<Seed> GetRandomSeeds(int minMoves, int maxMoves, bool allowObstructed, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be larger than 0");
            }
            List<Seed> seeds = new List<Seed>();
            using var conn = new SQLiteConnection(@"Data Source=SoTPuzzle.db;New=False;");
            using var cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT * FROM Puzzles WHERE moves_required BETWEEN @min AND @max AND obstructed <= @obstructed ORDER BY RANDOM() LIMIT @limit";
            //Values
            cmd.Parameters.AddWithValue("@min", minMoves);
            cmd.Parameters.AddWithValue("@max", maxMoves);
            cmd.Parameters.AddWithValue("@obstructed", allowObstructed ? 1 : 0);
            cmd.Parameters.AddWithValue("@limit", amount);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Seed seed = new Seed(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetBoolean(2)
                );
                seeds.Add(seed);
            }
            return seeds;
        }

        public Seed? GetRandomSeed(int minMoves, int maxMoves, bool allowObstructed)
        {
            var seeds = GetRandomSeeds(minMoves, maxMoves, allowObstructed, 1);
            if (seeds.Count == 0)
            {
                return null;
            }

            return seeds[0];
        }

        public Seed? GetRandomSeed(int minMoves, int maxMoves)
        {
            return GetRandomSeed(minMoves, maxMoves, false);
        }

        public Seed? GetRandomSeed(int moves)
        {
            return GetRandomSeed(moves, moves, false);
        }

        public Seed? GetRandomSeed(int moves, bool allowObstructed)
        {
            return GetRandomSeed(moves, moves, allowObstructed);
        }

        void Main()
        {
            GetRandomSeed(5);
        }
    }
}
