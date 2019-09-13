using CommentsPage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommentsPage.DAL
{
    public class Comments1 : DbContext
    {
        public Comments1() : base("Comments1")
        {
        }

        public DbSet<Comment> Comments { get; set; }
    }
}