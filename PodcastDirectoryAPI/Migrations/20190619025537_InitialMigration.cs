using Microsoft.EntityFrameworkCore.Migrations;

namespace PodcastDirectoryAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    PodcastID = table.Column<int>(nullable: false),
                    WebsiteURL = table.Column<string>(nullable: true),
                    FacebookPageURL = table.Column<string>(nullable: true),
                    TwitterPageURL = table.Column<string>(nullable: true),
                    InstagramHandle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "PodcastDetails",
                columns: table => new
                {
                    PodcastID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    YearLaunched = table.Column<int>(nullable: false),
                    LogoPath = table.Column<string>(nullable: true),
                    Active = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastDetails", x => x.PodcastID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PodcastID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "PodcastDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
