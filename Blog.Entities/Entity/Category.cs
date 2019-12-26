using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Entity
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MainCategoryId { get; set; }
        public Category MainCategory { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
