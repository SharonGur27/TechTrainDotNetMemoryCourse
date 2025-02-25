using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExercise
{
    class PotionStorage
    {
        private static List<byte[]> _storedPotions = new List<byte[]>();

        public void Store()
        {
            _storedPotions.Add(new byte[1024]); 
        }
    }
}
