using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class UpdatedCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaIndex");

            migrationBuilder.RenameColumn(
                name: "PizzaIndexId",
                table: "Order",
                newName: "PizzaId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Pizza",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Pizza");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "Order",
                newName: "PizzaIndexId");

            migrationBuilder.CreateTable(
                name: "PizzaIndex",
                columns: table => new
                {
                    PizzaIndexId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaIndex", x => x.PizzaIndexId);
                });
        }
    }
}
