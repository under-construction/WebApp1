using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TotalMoney = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Age", "GUID", "Name", "Surname", "TotalMoney" },
                values: new object[] { 1, 28, new Guid("bc3f02aa-6a07-4ac6-bbd4-5e93876772f1"), "Ercument", "Kalkan", 0 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Age", "GUID", "Name", "Surname", "TotalMoney" },
                values: new object[] { 2, 27, new Guid("d572c62f-aa0f-43e8-b89f-6e152a9e0ab4"), "Ezgi", "Gulsen", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
