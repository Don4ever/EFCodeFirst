namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondCup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Auth_id = c.Int(nullable: false, identity: true),
                        auth_name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Auth_id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PostDate = c.String(),
                        BlogId = c.Int(nullable: false),
                        AuhtId = c.Int(nullable: false),
                        post_PostId = c.Int(),
                        Author_Auth_id = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.post_PostId)
                .ForeignKey("dbo.Authors", t => t.Author_Auth_id)
                .Index(t => t.BlogId)
                .Index(t => t.post_PostId)
                .Index(t => t.Author_Auth_id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Auth_id", "dbo.Authors");
            DropForeignKey("dbo.Posts", "post_PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Author_Auth_id" });
            DropIndex("dbo.Posts", new[] { "post_PostId" });
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropTable("dbo.Blogs");
            DropTable("dbo.Posts");
            DropTable("dbo.Authors");
        }
    }
}
