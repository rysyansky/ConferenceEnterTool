using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConfEntTool
{
    public class LinksContext : DbContext
    {
        public DbSet<ConfLink> Links {  get; set; }
        public LinksContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ConfLinks.db");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ConfLink>().HasData(new ConfLink { LinkName = "Ip", LinkUrl = "http://ip.jsontest.com/", PassEnabled = false, CopyUrl = false });
        //}
    }
}
