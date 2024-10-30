using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class BookFeedbacks
    {
        public long InteractionId { get; set; }
        public string FeedBackText { get; set; }
        public string Mark { get; set; }
        public MarkEnum MarkEnum { get; set; }
        public UserBookInteraction UserBookInteraction { get; set; }
    }
}
