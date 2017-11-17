using ABB_Portal.Models.ABBEntityModels.ABBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.Initializers
{
    public class DBSeeder: CreateDatabaseIfNotExists<ABBPortalContext>
    {
        
            protected override void Seed(ABBPortalContext context)
            {
                Seeder seeder = new Seeder { SeederName = "Test1" };
                context.Seeder.Add(seeder);
                context.SaveChanges();

            }
        
    }
}
