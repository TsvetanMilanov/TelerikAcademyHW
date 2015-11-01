namespace Logs.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using Logs.Data;

    public sealed class Configuration : DbMigrationsConfiguration<Logs.Data.LogsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LogsDbContext context)
        {
        }
    }
}
