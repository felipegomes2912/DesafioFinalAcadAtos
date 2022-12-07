using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalAcadNet.Models;

public partial class DbWikiContext : DbContext
{
    public DbWikiContext()
    {
    }

    public DbWikiContext(DbContextOptions<DbWikiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Instrumento> Instrumentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=dbWiki;User ID=dbWiki;password=dbWiki;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;").UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Instrumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__instrume__3213E83FE22BCF64");

            entity.ToTable("instrumento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cor");
            entity.Property(e => e.Corda).HasColumnName("corda");
            entity.Property(e => e.DataFabricado)
                .HasColumnType("date")
                .HasColumnName("dataFabricado");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Percursao).HasColumnName("percursao");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.QntdEstoque).HasColumnName("qntdEstoque");
            entity.Property(e => e.Sopro).HasColumnName("sopro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
