using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookChat.Models
{
    public class FacebookIdentity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
