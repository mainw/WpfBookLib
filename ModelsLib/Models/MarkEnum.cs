﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class MarkEnum
    {
        public string Mark { get; set; }
        public IEnumerable<BookFeedbacks> BookFeedbacks { get; set; }
    }
}
