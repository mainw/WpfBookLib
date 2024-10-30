using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class UserBookInteraction
    {
        public long InteractionId { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
    }
}
