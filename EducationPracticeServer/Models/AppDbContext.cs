using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EducationPracticeServer.Models {

    public class AppDbContext : DbContext {

        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }
        public AppDbContext() { }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Major>(e => {
                e.HasIndex(x => x.Code).IsUnique();
            });
        }
    }
}
