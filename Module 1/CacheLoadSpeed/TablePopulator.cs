using BenchmarkDotNet.Attributes;

namespace CacheLoadSpeed
{
    public class TablePopulator
    {
        [Benchmark]
        public void PopulateRows()
        {
            int[,] tab = new int[5000, 5000];
            for (int i = 0; i < 5000; ++i)
            {
                for (int j = 0; j < 5000; ++j)
                {
                    tab[i, j] = 1;
                }
            }
        }

        [Benchmark]
        public void PopulateColumns()
        {
            int[,] tab = new int[5000, 5000];
            for (int i = 0; i < 5000; ++i)
            {
                for (int j = 0; j < 5000; ++j)
                {
                    tab[j, i] = 1;
                }
            }
        }
    }
}
