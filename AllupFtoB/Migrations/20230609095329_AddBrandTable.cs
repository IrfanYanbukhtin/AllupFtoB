using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllupFtoB.Migrations
{
    public partial class AddBrandTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_deliveries",
                table: "deliveries");

            migrationBuilder.RenameTable(
                name: "deliveries",
                newName: "Deliveries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "deliveries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_deliveries",
                table: "deliveries",
                column: "Id");
        }
    }
}
