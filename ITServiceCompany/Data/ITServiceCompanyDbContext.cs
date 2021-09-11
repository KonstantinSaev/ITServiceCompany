namespace ITServiceCompany.Data
{
    using ITServiceCompany.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ITServiceCompanyDbContext : DbContext
    {
		public ITServiceCompanyDbContext()
		{
		}

		public ITServiceCompanyDbContext(DbContextOptions options)
			: base(options)
		{
		}

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<WorkerService> WorkerServices { get; set; }

        public DbSet<Project> Projects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options
					.UseSqlServer("Server=DESKTOP-LOVERHL\\MSSQLSERVER11;Database=ITServiceCompany;Integrated Security=true");
			}
		}

		protected override void OnModelCreating(ModelBuilder model)
		{
			model.Entity<WorkerService>()
				.HasKey(x => new { x.WorkerId, x.ServiceId });
		}
	}
}
