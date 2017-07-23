using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comment.Models
{
    public class CommentVM
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Username { get; set; }

        public DateTime CreatedAt { get; set; }

        public int ArticleId { get; set; }

        public int StatusId { get; set; }

        public int ParentId { get; set; }
    }
}