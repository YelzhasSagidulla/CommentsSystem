using System;
using System.Web;
using System.Web.Mvc;
using Comment.Models;
using System.Collections.Generic;
using System.Linq;
using Comment.CommentsDatabaseDataSetTableAdapters;

namespace Comment.Controllers
{    
    public class CommentController : Controller
    {
        [HttpGet]
        public ICollection<CommentVM> GetComments(DateTime startDate, DateTime endDate)
        {
            var res = new List<CommentVM>();

            var adapter = new CommentsDatabaseDataSetTableAdapters.Get_CommentsTableAdapter();

            var data = adapter.GetData(startDate, endDate);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                res.Add(new CommentVM()
                {
                    Id = data[i].Id,
                    Content = data[i].Content,
                    Username = data[i].Username,
                    CreatedAt = new DateTime(1980, 1, 1).AddMilliseconds(BitConverter.ToInt64(data[i].CreatedAt, 0)),
                    ArticleId = data[i].ArticleId,
                    StatusId = data[i].StatusId,
                    ParentId = data[i].ParentId
                });
            }

            return res;
        }

        [HttpPost]
        public void CreateComment(CommentVM cmnt)
        {            
        }

        [HttpPut]
        public void UpdateComment(CommentVM cmnt)
        {
        }

        [HttpDelete]
        public void DeleteComment(int id)
        {
        }
    }
}