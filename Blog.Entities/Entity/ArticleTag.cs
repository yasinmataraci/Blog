using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entity
{
    public class ArticleTag
    {
        public int ArticleId { get; set; }
        public int TagId { get; set; }
        public Article Article { get; set; }
        public Tag Tag { get; set; }
    }
}
