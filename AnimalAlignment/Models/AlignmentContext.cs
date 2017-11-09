using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AnimalAlignment.Models
{
    public partial class AlignmentContext : DbContext
    {
        public virtual DbSet<Table> Table { get; set; }

        public AlignmentContext(DbContextOptions<AlignmentContext> options)
    : base(options)
{ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
