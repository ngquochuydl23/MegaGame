using Microsoft.EntityFrameworkCore;

namespace MegaGame.Api.Infrastructures
{
	public class MegaGameDbContext : DbContext
	{
		public MegaGameDbContext(DbContextOptions<MegaGameDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}
	}
}
