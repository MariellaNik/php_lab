using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab02.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Major_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Major",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Computer Science" });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Information Systems" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Description", "MajorId", "Name" },
                values: new object[] { 1, "C++ Programming", 1, "COS 120" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Description", "MajorId", "Name" },
                values: new object[] { 2, "Python Programming", 1, "COS 340" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Description", "MajorId", "Name" },
                values: new object[] { 3, "C# Programming", 2, "INF 130" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_MajorId",
                table: "Course",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Major_Name",
                table: "Major",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Major");
        }
    }
}
