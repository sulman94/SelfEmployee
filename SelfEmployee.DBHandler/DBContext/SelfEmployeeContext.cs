using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SelfEmployee.Models.ConfigurationRepositories;

namespace SelfEmployee.DBHandler.DBContext
{
    public class SelfEmployeeContext : IdentityDbContext<AppUser>
    {
        public SelfEmployeeContext(DbContextOptions<SelfEmployeeContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Tasks> Tasks { get; set; } = null!;
        public virtual DbSet<TaskCategory> TaskCategories { get; set; } = null!;
        public virtual DbSet<TaskImage> TaskImages { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("8120_SelfEmployeeApp");

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Details).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsFlexible).HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName).HasMaxLength(200);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaskName).HasMaxLength(300);

                entity.Property(e => e.TaskStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TasksCollection)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Tasks_TaskCategories");
            });

            modelBuilder.Entity<TaskCategory>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaskImage>(entity =>
            {
                entity.Property(e => e.ImageBase64).HasColumnType("text");

                entity.HasOne(d => d.ParentTask)
                    .WithMany(p => p.TaskImages)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskImages_Tasks");
            });
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }

}