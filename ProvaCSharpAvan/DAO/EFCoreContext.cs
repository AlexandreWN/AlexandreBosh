using Microsoft.EntityFrameworkCore;
namespace DAO;

public class EFCoreContext : DbContext
{
	public DbSet<Armas> Armas { get; set; }
	public DbSet<Batalhas> Batalhas { get; set; }
	public DbSet<Herois> Herois { get; set; }
	public DbSet<HeroisBatalhas> HeroisBatalhas { get; set; }
	public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source = JVLPC0565\\SQLEXPRESS; Initial Catalog = ProvaCSharp; Integrated Security = True");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Armas>(entity =>
		{
			entity.HasKey(a => a.id);
			entity.Property(a => a.name);
			entity.Property(a => a.IDheroi);
		});
		modelBuilder.Entity<Batalhas>(entity =>
		{
			entity.HasKey(b => b.id);
			entity.Property(b => b.name);
			entity.Property(b => b.description);
			entity.Property(b => b.DtInicio);
			entity.Property(b => b.DtFim);
		});
		modelBuilder.Entity<Herois>(entity =>
		{
			entity.HasKey(h => h.id);
			entity.Property(h => h.name);
			entity.HasOne(h => h.armas);
		});
		modelBuilder.Entity<HeroisBatalhas>(entity =>
		{
			entity.HasKey(hb => hb.id);
			entity.HasOne(hb => hb.batalhas);
			entity.HasOne(hb => hb.herois);
		});
		modelBuilder.Entity<IdentidadeSecreta>(entity =>
		{
			entity.HasKey(i => i.id);
			entity.Property(i => i.realName);
			entity.Property(i => i.IDherois);
		});
	}
}