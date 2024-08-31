using System;
using LockBase_DMS_Service.Model;
using Microsoft.EntityFrameworkCore;

namespace LockBase_DMS_Service.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
			// base(options) would get and put all the data accessed from DB to the context
		}

        // Define all the models (data layer) here
		public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }

        /* 
         * This is for mapping the relationships
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                    .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(p => p.PokemonId);
        }
        */
    }
}

