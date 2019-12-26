using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entity
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
