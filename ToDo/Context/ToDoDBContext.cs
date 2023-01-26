using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entitites;

namespace ToDo.Context
{
    public class ToDoDBContext: DbContext
    {
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<TaskColor> TaskColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTask>()
                .HasOne<TaskColor>(t=>t.TaskColor)
                .WithMany(c=>c.Tasks)
                .HasForeignKey(t => t.TaskColorId);

            modelBuilder.Entity<ToDoTask>()
                .Property(t => t.Description)
                .HasMaxLength(255);

            modelBuilder.Entity<ToDoTask>()
                .Property(t => t.Place)
                .HasMaxLength(100);


        }

        public ToDoDBContext() : base() { }
        public ToDoDBContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-I7Q35NQ\SQLEXPRESS;Database=ToDoList;Trusted_Connection=True;Encrypt=False; Integrated Security=True ");
        }
    }
}
