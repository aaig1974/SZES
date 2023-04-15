using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using SZES.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SZES.Data;

public partial class ZeiterfassungContext : DbContext
{
    public ZeiterfassungContext()
    {
    }

    public ZeiterfassungContext(DbContextOptions<ZeiterfassungContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anwesenheit> Anwesenheits { get; set; }

    public virtual DbSet<Azubi> Azubis { get; set; }

    public virtual DbSet<Azubianwesenheit> Azubianwesenheits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Data Source=NICK\\SQLEXPRESS;Initial Catalog=Zeiterfassung;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anwesenheit>(entity =>
        {
            entity.HasKey(e => e.AnwensenId).HasName("PK__Anwesenh__8BCEBD47896BF5FE");
        });

        modelBuilder.Entity<Azubi>(entity =>
        {
            entity.HasKey(e => e.AzubiId).HasName("PK__azubi__876FDBAE9B91F466");
        });

        modelBuilder.Entity<Azubianwesenheit>(entity =>
        {
            entity.HasKey(e => e.AzubanweId).HasName("PK__Azubianw__BAFB4E34D043519F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
