using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comment.Models;
using Comment.CommentsDatabaseDataSetTableAdapters;

namespace Comment.Controllers
{
    public class StatusController : Controller
    {
        [HttpGet]
        public ICollection<StatusVM> GetStatuses()
        {
            var res = new List<StatusVM>();

            var adapter = new CommentsDatabaseDataSetTableAdapters.Get_StatusesTableAdapter();

            var data = adapter.GetData();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                res.Add(new StatusVM()
                {
                    Id = data[i].Id,
                    Title = data[i].Title
                });
            }

            return res;
        }
    }
}