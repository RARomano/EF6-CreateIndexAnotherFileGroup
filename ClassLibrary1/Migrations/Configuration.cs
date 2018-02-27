namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClassLibrary1.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            // Use the custom SQL generator to handle the index creation 
            SetSqlGenerator("System.Data.SqlClient", new ExtendedSqlServerMigrationsSqlGenerator());
        }

        protected override void Seed(ClassLibrary1.AppDbContext context)
        {

        }
    }
}
