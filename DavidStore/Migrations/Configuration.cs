namespace BabyStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DavidStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DavidStore.Models.ApplicationDbContext";
        }

        protected override void Seed(DavidStore.Models.ApplicationDbContext context)
        {
            
        }
    }
}
