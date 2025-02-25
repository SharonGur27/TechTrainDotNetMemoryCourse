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
            await Task.Run(() =>
            {
                // simulate work
                Task.Delay(1000).Wait();
                // Capturing byteArray in closure
                Console.WriteLine(byteArray.Length);
            });
        }
    }
}
