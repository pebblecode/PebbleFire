using System;
using System.Collections.Generic;
using System.Linq;

namespace PebbleFire
{
    public class MessageViewModel
    {
        private CampfireMessage message;

        public MessageViewModel(CampfireMessage message)
        {
            this.message = message;
        }

        public string Message
        {
            get { return message.Text; }
        }
    }
}
