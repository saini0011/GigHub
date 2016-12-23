namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT Into Genres (Id,Name) VALUES(1,'Jazz')");
            Sql("INSERT Into Genres (Id,Name) VALUES(2,'Blues')");
            Sql("INSERT Into Genres (Id,Name) VALUES(3,'Rocks')");
            Sql("INSERT Into Genres (Id,Name) VALUES(4,'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE from Genres Where Id IN (1,2,3,4)");
        }
    }
}
