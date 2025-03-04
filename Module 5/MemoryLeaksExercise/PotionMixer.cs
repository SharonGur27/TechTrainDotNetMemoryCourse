using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExercise
{
    class PotionMixer
    {
        public async Task MixAsync()
        {
            var byteArray = new byte[1024];
            _ = Task.Run(() =>
            {
                // Capturing byteArray in closure
                Console.WriteLine(byteArray.Length);

                // simulate work
                Task.Delay(int.MaxValue).Wait();
            });
        }
    }
}
