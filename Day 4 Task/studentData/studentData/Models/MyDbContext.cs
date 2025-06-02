using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace studentData.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("student_pkey");

            entity.ToTable("student");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Fathername)
                .HasMaxLength(100)
                .HasColumnName("fathername");
            entity.Property(e => e.Standard).HasColumnName("standard");
            entity.Property(e => e.Studentgender)
                .HasMaxLength(100)
                .HasColumnName("studentgender");
            entity.Property(e => e.Studentname)
                .HasMaxLength(100)
                .HasColumnName("studentname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
