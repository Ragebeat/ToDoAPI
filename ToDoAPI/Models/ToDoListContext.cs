using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ToDoAPI.Models
{
    public partial class ToDoListContext : DbContext
    {
        public ToDoListContext()
        {
        }

        public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MyTask> MyTask { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_Task");

                entity.Property(e => e.TaskId).HasColumnName("taskId");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CompleteTime)
                    .HasColumnName("completeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.DeadLine).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Importance).HasColumnName("importance");

                entity.Property(e => e.IsComplete).HasColumnName("isComplete");

                entity.Property(e => e.LastPerformer).HasColumnName("lastPerformer");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.Parrent).HasColumnName("parrent");

                entity.Property(e => e.Performer).HasColumnName("performer");

                entity.Property(e => e.Project).HasColumnName("project");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskLog).HasColumnName("taskLog");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
