using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Common.Models;

namespace Deployment.Clients
{
    public class Avengers : Client
    {
        private static List<string> _members = new List<string>();

        public Avengers()
        {
            Name = "Avengers";
            Location = "New York";
            _members.Add("Iron Man");
            _members.Add("Captain America");
            _members.Add("Thor");
            RaiseReceivedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - Located in {Location}";
        }
    }
}