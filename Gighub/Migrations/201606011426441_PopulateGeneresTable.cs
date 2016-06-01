namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGeneresTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Id,Name) values (1, 'Jazz')");
            Sql("insert into Genres(Id,Name) values (2, 'Blues')");
            Sql("insert into Genres(Id,Name) values (3, 'Rock')");
            Sql("insert into Genres(Id,Name) values (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("Delete from Genres where Id IN(1,2,3,4)");
        }
    }
}
