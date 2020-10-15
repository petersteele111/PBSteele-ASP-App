using Microsoft.EntityFrameworkCore.Migrations;

namespace PBsteele.Migrations
{
    public partial class CreatedAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blog");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Blog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Email", "Name", "Phone" },
                values: new object[] { 1, "petersteele@gmail.com", "Peter Steele", "231-357-1970" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Email", "Name", "Phone" },
                values: new object[] { 2, "lbalbach@nmc.edu", "Lisa Balbach", "231-645-5555" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Email", "Name", "Phone" },
                values: new object[] { 3, "mjones@example.com", "Mark Jones", "555-555-1234" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 1,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 2,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 3,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 4,
                column: "AuthorId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AuthorId",
                table: "Blog",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Author_AuthorId",
                table: "Blog",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Author_AuthorId",
                table: "Blog");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Blog_AuthorId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Blog");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 1,
                column: "Author",
                value: "Peter Steele");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 2,
                column: "Author",
                value: "Peter Steele");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 3,
                column: "Author",
                value: "Peter Steele");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogID",
                keyValue: 4,
                column: "Author",
                value: "Peter Steele");
        }
    }
}
