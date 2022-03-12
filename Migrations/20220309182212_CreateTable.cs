using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiStoreWeb.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchase_smartphone_Id",
                table: "purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_smartphone",
                table: "smartphone");

            migrationBuilder.RenameTable(
                name: "smartphone",
                newName: "smartphones");

            migrationBuilder.AddPrimaryKey(
                name: "PK_smartphones",
                table: "smartphones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_purchase_smartphones_Id",
                table: "purchase",
                column: "Id",
                principalTable: "smartphones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchase_smartphones_Id",
                table: "purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_smartphones",
                table: "smartphones");

            migrationBuilder.RenameTable(
                name: "smartphones",
                newName: "smartphone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_smartphone",
                table: "smartphone",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_purchase_smartphone_Id",
                table: "purchase",
                column: "Id",
                principalTable: "smartphone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
