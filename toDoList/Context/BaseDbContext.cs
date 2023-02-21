using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using toDoList.Data.Models;

namespace toDoList.Context
{
    public class BaseDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<ThingstoDo> thingstoDo { get; set; }
        public DbSet<BeingDone> beingDone { get; set; }
        public DbSet<Done> done { get; set; }

    }
}
