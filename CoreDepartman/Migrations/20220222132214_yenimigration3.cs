using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class yenimigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmanID",
                table: "personel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personel_DepartmanID",
                table: "personel",
                column: "DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_personel_departman_DepartmanID",
                table: "personel",
                column: "DepartmanID",
                principalTable: "departman",
                principalColumn: "DepartmanID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personel_departman_DepartmanID",
                table: "personel");

            migrationBuilder.DropIndex(
                name: "IX_personel_DepartmanID",
                table: "personel");

            migrationBuilder.DropColumn(
                name: "DepartmanID",
                table: "personel");
        }
    }
}
