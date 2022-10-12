using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyrodWebAppMVC.Migrations
{
    public partial class AddedRodImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RodImage",
                table: "Flyrods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 1,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 2,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 3,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 4,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 5,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 6,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 7,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 8,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 9,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 10,
                column: "RodImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Flyrods",
                keyColumn: "Id",
                keyValue: 11,
                column: "RodImage",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RodImage",
                table: "Flyrods");
        }
    }
}
