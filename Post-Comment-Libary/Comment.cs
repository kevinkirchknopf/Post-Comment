﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Comment_Libary
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Content { get; set; }

        public string? UserComment { get; set; }
        public Comment comment { get; set; }
        
    }
}
