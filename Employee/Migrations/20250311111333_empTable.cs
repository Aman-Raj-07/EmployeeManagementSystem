using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employee.Migrations
{
    /// <inheritdoc />
    public partial class empTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Emps",
                columns: new[] { "id", "city", "departmentId", "gender", "mobile", "name", "salary" },
                values: new object[,]
                {
                    { 1, "New York", 1, "male", "1234567890", "John", 50000 },
                    { 2, "Los Angeles", 2, "male", "1234567890", "Smith", 60000 },
                    { 3, "Mumbai", 3, "male", "1234567890", "Ravi", 70000 },
                    { 4, "Pune", 4, "female", "1234567890", "Kavita", 80000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");
        }
    }
}
