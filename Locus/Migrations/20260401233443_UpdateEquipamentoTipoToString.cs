using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locus.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEquipamentoTipoToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Equipamentos",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tipo",
                value: "Notebook");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tipo",
                value: "Notebook");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tipo",
                value: "Impressora");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tipo",
                value: "Desktop");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tipo",
                value: "Notebook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Equipamentos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tipo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tipo",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tipo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tipo",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tipo",
                value: 1);
        }
    }
}
