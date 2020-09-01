using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BLOGGER_FETHULLAHKAYA.Migrations
{
    public partial class kaya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ARTICLES",
                columns: table => new
                {
                    ARTICLE_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARTICLE_AUTHOR_ID = table.Column<int>(nullable: false),
                    ARTICLE_CREATE_DATE = table.Column<DateTime>(nullable: false),
                    ARTICLE_EDIT_AUTHOR_ID = table.Column<int>(nullable: false),
                    ARTICLE_EDIT_DATE = table.Column<DateTime>(nullable: false),
                    ARTICLE_TITLE = table.Column<string>(nullable: true),
                    ARTICLE_IMAGEURL = table.Column<string>(nullable: true),
                    ARTICLE_DESCRIPTION = table.Column<string>(nullable: true),
                    ARTICLE_CONTENT = table.Column<string>(nullable: true),
                    ARTICLE_ISACTIVE = table.Column<bool>(nullable: false),
                    ARTICLE_LIKE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICLES", x => x.ARTICLE_ID);
                });

            migrationBuilder.CreateTable(
                name: "AUTHORS",
                columns: table => new
                {
                    AUTOHOR_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AUTHOR_NAME = table.Column<string>(maxLength: 20, nullable: false),
                    AUTHOR_SURNAME = table.Column<string>(maxLength: 20, nullable: false),
                    AUTHOR_CREATE_DATE = table.Column<DateTime>(nullable: false),
                    AUTHOR_ISACTIVE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTHORS", x => x.AUTOHOR_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARTICLES");

            migrationBuilder.DropTable(
                name: "AUTHORS");
        }
    }
}
