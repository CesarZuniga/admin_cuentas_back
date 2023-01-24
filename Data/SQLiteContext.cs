using Admin.Cuentas.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin.Cuentas.Data;

public partial class SQLiteContext : DbContext
{
    public SQLiteContext(DbContextOptions<SQLiteContext> options)
       : base(options)
    {
    }
    public virtual DbSet<Meses> Meses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Meses>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

