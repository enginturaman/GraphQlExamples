﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graphql.Storage.GraphlModels
{
    public class Book
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool Published { get; set; }

        public string Genre { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
