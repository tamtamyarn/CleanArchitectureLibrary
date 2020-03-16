using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addbooktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_publishingCompanies",
                table: "publishingCompanies");

            migrationBuilder.RenameTable(
                name: "publishingCompanies",
                newName: "PublishingCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishingCompanies",
                table: "PublishingCompanies",
                column: "PublishingCompanyId");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    PublishingCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_PublishingCompanies_PublishingCompanyId",
                        column: x => x.PublishingCompanyId,
                        principalTable: "PublishingCompanies",
                        principalColumn: "PublishingCompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublishingCompanyId",
                table: "Books",
                column: "PublishingCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishingCompanies",
                table: "PublishingCompanies");

            migrationBuilder.RenameTable(
                name: "PublishingCompanies",
                newName: "publishingCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishingCompanies",
                table: "publishingCompanies",
                column: "PublishingCompanyId");
        }
    }
}
