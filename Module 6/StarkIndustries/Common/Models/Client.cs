using System;

namespace Common.Models
{
    public abstract class Client
    {
        public event EventHandler OnReceived;

        public string Name { get; set; }
        public string Location { get; set; }

        protected void RaiseReceivedEvent()
        {
            OnReceived?.Invoke(this, EventArgs.Empty);
        }

        public abstract string GetDescription();
    }
}