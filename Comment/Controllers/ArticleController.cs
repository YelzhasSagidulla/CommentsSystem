using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comment.Models;
using Comment.CommentsDatabaseDataSetTableAdapters;

namespace Comment.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        public ICollection<ArticleVM> GetArticles()
        {
            var res = new List<ArticleVM>();

            var adapter = new CommentsDatabaseDataSetTableAdapters.Get_ArticlesTableAdapter();

            var data = adapter.GetData();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                res.Add(new ArticleVM()
                {
                    Id = data[i].Id,
                    Title = data[i].Title,
                    Description = data[i].Description
                });
            }

            return res;
        }
    }
}