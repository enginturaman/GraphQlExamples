﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlModels
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
    }
}
