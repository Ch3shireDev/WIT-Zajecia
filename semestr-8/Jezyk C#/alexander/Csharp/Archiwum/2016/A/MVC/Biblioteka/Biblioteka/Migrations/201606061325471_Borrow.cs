namespace Biblioteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Borrow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        borrowId = c.Int(nullable: false, identity: true),
                        dateBorrow = c.DateTime(nullable: false),
                        dateReturn = c.DateTime(nullable: false),
                        IDCard = c.Int(nullable: false),
                        IDBook = c.Int(nullable: false),
                        books_bookId = c.Int(),
                        readers_readerId = c.Int(),
                    })
                .PrimaryKey(t => t.borrowId)
                .ForeignKey("dbo.Books", t => t.books_bookId)
                .ForeignKey("dbo.Readers", t => t.readers_readerId)
                .Index(t => t.books_bookId)
                .Index(t => t.readers_readerId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        bookId = c.Int(nullable: false, identity: true),
                        author = c.String(),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.bookId);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        readerId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                    })
                .PrimaryKey(t => t.readerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrows", "readers_readerId", "dbo.Readers");
            DropForeignKey("dbo.Borrows", "books_bookId", "dbo.Books");
            DropIndex("dbo.Borrows", new[] { "readers_readerId" });
            DropIndex("dbo.Borrows", new[] { "books_bookId" });
            DropTable("dbo.Readers");
            DropTable("dbo.Books");
            DropTable("dbo.Borrows");
        }
    }
}
