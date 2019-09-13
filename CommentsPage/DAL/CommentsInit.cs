using CommentsPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentsPage.DAL
{
    public class CommentsInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<Comments1>
    {
        protected override void Seed(Comments1 context)
        {
            var students = new List<Comment>
            {
            new Comment{Id= 1,Name="Jack",Comments = "abcd"},
            new Comment{Id= 2,Name="Jason",Comments = "efgh"},
            new Comment{Id= 3,Name="Jay",Comments = "ijkl"},
            new Comment{Id= 4,Name="Jones",Comments = "mnop"},
            new Comment{Id= 5,Name="Ben",Comments = "qrst"},

            };

            students.ForEach(s => context.Comments.Add(s));
            context.SaveChanges();
        }
    }
}