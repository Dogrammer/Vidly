namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId) VALUES('Shrek', 1)");
            Sql("INSERT INTO Movies (Name,GenreId) VALUES('Harry Potter', 2)");
            Sql("INSERT INTO Movies (Name,GenreId) VALUES('Friday', 1)");
            Sql("INSERT INTO Movies (Name,GenreId) VALUES('Hercules', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
