namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover','Comedy','20091106','20160504',5)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberInStock) VALUES ('DieHard','Action','20091106','20160504',8)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberInStock) VALUES ('The Terminator','Action','20091106','20160504',3)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberInStock) VALUES ('Toy Story','Family','20091106','20160504',6)");
            Sql("INSERT INTO Movies(Name,Genre,ReleaseDate,DateAdded,NumberInStock) VALUES ('Titanic','Romance','20091106','20160504',7)");
        }
        
        public override void Down()
        {
        }
    }
}
