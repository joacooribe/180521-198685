using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Persistence
{
   public class ContextDB : DbContext
    {
        public ContextDB() : base() { }
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Colaborator> Colaborators { get; set; }
        public DbSet<Blackboard> Blackboards { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TextBox> TextBoxes { get; set; }
        public DbSet<Image> Images { get; set; }


    }
}
