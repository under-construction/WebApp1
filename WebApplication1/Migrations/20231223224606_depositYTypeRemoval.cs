using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class depositYTypeRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeId",
                table: "Deposits");

            migrationBuilder.DropColumn(
                name: "DeposityTypeId",
                table: "Deposits");

            migrationBuilder.AlterColumn<int>(
                name: "DepositTypeId",
                table: "Deposits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeId",
                table: "Deposits",
                column: "DepositTypeId",
                principalTable: "DepositTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeId",
                table: "Deposits");

            migrationBuilder.AlterColumn<int>(
                name: "DepositTypeId",
                table: "Deposits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DeposityTypeId",
                table: "Deposits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeId",
                table: "Deposits",
                column: "DepositTypeId",
                principalTable: "DepositTypes",
                principalColumn: "ID");
        }
    }
}
