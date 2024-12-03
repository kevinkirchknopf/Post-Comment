using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Comment_Libary
{
    public class Context:DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "server=localhost;userid=root;password=;database=Blog";

            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }
    }
}
