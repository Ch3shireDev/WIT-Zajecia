namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wypozyczenias",
                c => new
                    {
                        wypozyczeniaId = c.Int(nullable: false, identity: true),
                        dataWyp = c.DateTime(nullable: false),
                        dataZwr = c.DateTime(nullable: false),
                        czytel_czytelnikId = c.Int(),
                        ksiazka_ksiazkaId = c.Int(),
                    })
                .PrimaryKey(t => t.wypozyczeniaId)
                .ForeignKey("dbo.Czytelniks", t => t.czytel_czytelnikId)
                .ForeignKey("dbo.Ksiazkas", t => t.ksiazka_ksiazkaId)
                .Index(t => t.czytel_czytelnikId)
                .Index(t => t.ksiazka_ksiazkaId);
            
            CreateTable(
                "dbo.Czytelniks",
                c => new
                    {
                        czytelnikId = c.Int(nullable: false, identity: true),
                        imie = c.String(),
                        nazwisko = c.String(),
                    })
                .PrimaryKey(t => t.czytelnikId);
            
            CreateTable(
                "dbo.Ksiazkas",
                c => new
                    {
                        ksiazkaId = c.Int(nullable: false, identity: true),
                        tytul = c.String(),
                        autor = c.String(),
                    })
                .PrimaryKey(t => t.ksiazkaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wypozyczenias", "ksiazka_ksiazkaId", "dbo.Ksiazkas");
            DropForeignKey("dbo.Wypozyczenias", "czytel_czytelnikId", "dbo.Czytelniks");
            DropIndex("dbo.Wypozyczenias", new[] { "ksiazka_ksiazkaId" });
            DropIndex("dbo.Wypozyczenias", new[] { "czytel_czytelnikId" });
            DropTable("dbo.Ksiazkas");
            DropTable("dbo.Czytelniks");
            DropTable("dbo.Wypozyczenias");
        }
    }
}
