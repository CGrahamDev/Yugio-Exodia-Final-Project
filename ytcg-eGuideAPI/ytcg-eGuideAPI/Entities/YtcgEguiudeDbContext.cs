using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ytcg_eGuideAPI.Entities;

public partial class YtcgEguiudeDbContext : DbContext
{
    public YtcgEguiudeDbContext()
    {
    }

    public YtcgEguiudeDbContext(DbContextOptions<YtcgEguiudeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OwnedCard> OwnedCards { get; set; }

    public virtual DbSet<StarterPack> StarterPacks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OwnedCard>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.Starter).WithMany()
                .HasForeignKey(d => d.StarterId)
                .HasConstraintName("FK__OwnedCard__Start__60A75C0F");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__OwnedCard__UserI__5FB337D6");
        });

        modelBuilder.Entity<StarterPack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StarterP__3214EC070670AE18");

            entity.ToTable("StarterPack");

            entity.Property(e => e.Attribute).HasMaxLength(32);
            entity.Property(e => e.Description).HasMaxLength(128);
            entity.Property(e => e.FrameType).HasMaxLength(16);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(256)
                .HasColumnName("ImageURL");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Race).HasMaxLength(32);
            entity.Property(e => e.Type).HasMaxLength(64);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07C7FEC463");

            entity.ToTable("User");

            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
