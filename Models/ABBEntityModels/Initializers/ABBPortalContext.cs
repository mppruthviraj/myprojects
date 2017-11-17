using ABB_Portal.Models.ABBEntityModels.ABBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.Initializers
{
    public class ABBPortalContext:DbContext
    {
        public ABBPortalContext():base("name=ABBPortalContext")
        {
            Database.SetInitializer<ABBPortalContext>(new CreateDatabaseIfNotExists<ABBPortalContext>());
        }

        public DbSet<ABBTestimonials> ABBTestimonials { get; set; }

        public DbSet<Seeder> Seeder { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
