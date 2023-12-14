using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class birthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Person",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Person");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Age", "Name", "Surname", "TotalMoney" },
                values: new object[] { 1, 28, "Ercument", "Kalkan", 0 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Age", "Name", "Surname", "TotalMoney" },
                values: new object[] { 2, 27, "Ezgi", "Gulsen", 0 });
        }
    }
}
