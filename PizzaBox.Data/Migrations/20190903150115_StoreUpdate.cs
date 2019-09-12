using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class StoreUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Location_LocationName",
                table: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Location",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationName",
                table: "Location",
                column: "LocationName",
                unique: true,
                filter: "[LocationName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Location_LocationName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Location",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationName",
                table: "Location",
                column: "LocationName",
                unique: true);
        }
    }
}
