using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class TaskAssignmentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9PPQMPK;database=TaskAssignment;Trusted_Connection=true");
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }





    }
}
