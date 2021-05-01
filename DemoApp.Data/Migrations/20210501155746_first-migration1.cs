using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoApp.Data.Migrations
{
    public partial class firstmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClanId",
                table: "Samurais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClanName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_ClanId",
                table: "Samurais",
                column: "ClanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_Clans_ClanId",
                table: "Samurais",
                column: "ClanId",
                principalTable: "Clans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_Clans_ClanId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "Clans");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_ClanId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "ClanId",
                table: "Samurais");
        }
    }
}
