using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using toDoList.Data.Models;

namespace toDoList.Context
{
    public class BaseDbContext: DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=TodoList;Trusted_Connection=true");
        //}
        public BaseDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ToDoList> toDoLists { get; set; }

    }
}
