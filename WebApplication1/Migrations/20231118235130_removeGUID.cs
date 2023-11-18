using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class removeGUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GUID",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GUID",
                table: "Person",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 1,
                column: "GUID",
                value: new Guid("bc3f02aa-6a07-4ac6-bbd4-5e93876772f1"));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2,
                column: "GUID",
                value: new Guid("d572c62f-aa0f-43e8-b89f-6e152a9e0ab4"));
        }
    }
}
