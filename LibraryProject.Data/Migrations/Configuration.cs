namespace LibraryProject.Data.Migrations
{  
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<LibraryProject.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "LibraryProject.Data.Context";
        }

        protected override void Seed(LibraryProject.Data.Context context)
        {
           
        }
    }
}
