using System.Data.Entity.Migrations;

namespace TMDT_BanHang.Migrations
{
    public class Configuration : DbMigrationsConfiguration<DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}