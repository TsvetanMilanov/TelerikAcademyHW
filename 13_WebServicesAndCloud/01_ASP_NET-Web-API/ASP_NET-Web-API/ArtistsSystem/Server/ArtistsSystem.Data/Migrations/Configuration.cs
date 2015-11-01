namespace ArtistsSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Data;

    public sealed class Configuration : DbMigrationsConfiguration<ArtistsSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ArtistsSystemDbContext context)
        {
        }
    }
}
