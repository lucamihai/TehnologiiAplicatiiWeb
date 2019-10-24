using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        //public decimal Name { get; set; }
        //public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
