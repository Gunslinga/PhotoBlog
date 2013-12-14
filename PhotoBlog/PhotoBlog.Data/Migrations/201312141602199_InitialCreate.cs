namespace PhotoBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PhotoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CategoryId = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Categories", t => t.Parent_CategoryId)
                .Index(t => t.Parent_CategoryId);
            
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPosts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Photo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Photos", t => t.Photo_Id)
                .Index(t => t.Photo_Id);
            
            CreateTable(
                "dbo.TagBlogPosts",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        BlogPost_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.BlogPost_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPost_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.BlogPost_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Tags", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.Photos", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.TagBlogPosts", "BlogPost_Id", "dbo.BlogPosts");
            DropForeignKey("dbo.TagBlogPosts", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.BlogPosts", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Comments", "PostId", "dbo.BlogPosts");
            DropForeignKey("dbo.Categories", "Parent_CategoryId", "dbo.Categories");
            DropIndex("dbo.Photos", new[] { "AlbumId" });
            DropIndex("dbo.Tags", new[] { "Photo_Id" });
            DropIndex("dbo.Photos", new[] { "CategoryId" });
            DropIndex("dbo.TagBlogPosts", new[] { "BlogPost_Id" });
            DropIndex("dbo.TagBlogPosts", new[] { "Tag_Id" });
            DropIndex("dbo.BlogPosts", new[] { "CategoryId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Categories", new[] { "Parent_CategoryId" });
            DropTable("dbo.TagBlogPosts");
            DropTable("dbo.Tags");
            DropTable("dbo.Comments");
            DropTable("dbo.BlogPosts");
            DropTable("dbo.Categories");
            DropTable("dbo.Photos");
            DropTable("dbo.Albums");
        }
    }
}
