using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class Comment
    {
        public long InteractionId { get; set; }
        public string CommentText { get; set; }
        public UserBookInteraction UserBookInteraction { get; set; }
    }
}
