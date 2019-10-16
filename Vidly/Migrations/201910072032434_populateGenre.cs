namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES('Western')");
            Sql("INSERT INTO Genres (Name) VALUES('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES('Action')");
        }
        
        public override void Down()
        {
        }
    }
}
