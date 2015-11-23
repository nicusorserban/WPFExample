using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookChat.Models
{
    public class ChatMessage
    {
        public DateTime TimeStamp { get; set; }

        public FacebookIdentity From { get; set; }

        public string Text { get; set; }
    }
}
