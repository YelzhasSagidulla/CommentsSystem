using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comment.Models
{
    public class ArticleVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }        
    }
}