using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FakultetMVC.Models;

namespace FakultetMVC.Models
{
    public class FakultetMVCContext : DbContext
    {
        public FakultetMVCContext (DbContextOptions<FakultetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<FakultetMVC.Models.Student> Student { get; set; }

        public DbSet<FakultetMVC.Models.Teacher> Teacher { get; set; }

        public DbSet<FakultetMVC.Models.Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.StudentId);

            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.CourseId);

            builder.Entity<Course>()
                .HasOne<Teacher>(p => p.Teacher)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.FirstTeacherId)
                .HasForeignKey(p => p.SecondTeacherId);
        }

    }
}
