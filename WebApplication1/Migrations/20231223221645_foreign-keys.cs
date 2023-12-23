using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class foreignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepositTypeId",
                table: "Deposits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_CurrencyId",
                table: "Deposits",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_DepositTypeId",
                table: "Deposits",
                column: "DepositTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_PersonId",
                table: "Deposits",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Currencies_CurrencyId",
                table: "Deposits",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeId",
                table: "Deposits",
                column: "DepositTypeId",
                principalTable: "DepositTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Person_PersonId",
                table: "Deposits",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Currencies_CurrencyId",
                table: "Deposits");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_DepositTypes_DepositTypeID",
                table: "Deposits");

            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Person_PersonId",
                table: "Deposits");

            migrationBuilder.DropIndex(
                name: "IX_Deposits_CurrencyId",
                table: "Deposits");

            migrationBuilder.DropIndex(
                name: "IX_Deposits_DepositTypeID",
                table: "Deposits");

            migrationBuilder.DropIndex(
                name: "IX_Deposits_PersonId",
                table: "Deposits");

            migrationBuilder.DropColumn(
                name: "DepositTypeId",
                table: "Deposits");
        }
    }
}
