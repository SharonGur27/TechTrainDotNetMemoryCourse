using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Models;
using Deployment.Clients;

namespace Deployment
{
    public class Distribution
    {
        private ArrayList _clients = new ArrayList(); // Non-generic collection (Unnecessary Boxing/Unboxing)

        public async Task StartDistributionAsync()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                Console.WriteLine($"Distributing gadgets batch {i}");

                // Create different types of clients
                var avengers = new Avengers();
                var shield = new Shield();

                // Introduce memory issues
                _clients.Add(avengers); // Boxing
                _clients.Add(shield); // Boxing
                avengers.OnReceived += (sender, args) => { /* Do something */ };
                shield.OnReceived += (sender, args) => { /* Do something */ };
            }
        }
    }
}