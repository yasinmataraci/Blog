﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entity
{
    public class Comment : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
