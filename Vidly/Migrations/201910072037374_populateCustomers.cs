namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, Birthday, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Ivan Ivic', '01-01-2001', 'true', 1)");
            Sql("INSERT INTO Customers (Name, Birthday, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Marko Markic', '01-01-2005', 'true', 2)");
            Sql("INSERT INTO Customers (Name, Birthday, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Stjepan Stjepko', '01-01-2006', 'true', 3)");
            Sql("INSERT INTO Customers (Name, Birthday, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Pero Peric', '01-01-2007', 'true', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
