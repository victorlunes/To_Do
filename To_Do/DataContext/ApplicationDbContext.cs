using System;
using Microsoft.EntityFrameworkCore;
using To_Do.Models;

namespace To_Do.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
