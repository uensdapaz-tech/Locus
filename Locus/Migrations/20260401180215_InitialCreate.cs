using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Locus.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    SetorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipamentos_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataAbertura = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    SetorId = table.Column<int>(type: "integer", nullable: false),
                    EquipamentoId = table.Column<int>(type: "integer", nullable: true),
                    TipoServicoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_Equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Equipamentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chamados_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamados_TiposServico_TipoServicoId",
                        column: x => x.TipoServicoId,
                        principalTable: "TiposServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Setores",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Secretaria" },
                    { 2, "Financeiro" },
                    { 3, "Biblioteca" }
                });

            migrationBuilder.InsertData(
                table: "TiposServico",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Instalação SO" },
                    { 2, "Instalação Office" },
                    { 3, "Montagem" },
                    { 4, "Instalação Driver" },
                    { 5, "Instalação Toner" },
                    { 6, "Ativação Windows" }
                });

            migrationBuilder.InsertData(
                table: "Equipamentos",
                columns: new[] { "Id", "Modelo", "SetorId", "Tipo" },
                values: new object[,]
                {
                    { 1, "Montagem i3", 1, 0 },
                    { 2, "Acer Aspire 3", 1, 1 },
                    { 3, "Notebook G1", 1, 1 },
                    { 4, "Desktop S1", 1, 0 },
                    { 5, "Desktop S2", 1, 0 },
                    { 6, "Desktop B1", 3, 0 },
                    { 7, "HP LaserJet", 3, 2 },
                    { 8, "Desktop F1", 2, 0 },
                    { 9, "Desktop F2", 2, 0 },
                    { 10, "Desktop F3", 2, 0 },
                    { 11, "Notebook S3", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Chamados",
                columns: new[] { "Id", "DataAbertura", "Descricao", "EquipamentoId", "SetorId", "Status", "TipoServicoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Montagem de computador i3 segunda geração", 1, 1, 2, 3 },
                    { 2, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação do Windows 10 — Notebook Acer Aspire 3, configurar boot", 2, 1, 2, 1 },
                    { 3, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação Office 365 — Notebook", 3, 1, 2, 2 },
                    { 4, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Computador travando, impressora não abre", 4, 1, 2, 3 },
                    { 5, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Ativar Windows", 5, 1, 2, 6 },
                    { 6, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação Office 365 — Desktop", 6, 3, 2, 2 },
                    { 7, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação de Toner", 7, 3, 2, 5 },
                    { 8, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação de SSD — Desktop", 8, 2, 2, 3 },
                    { 9, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação do Windows 10 — Desktop", 9, 2, 2, 1 },
                    { 10, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação de driver de impressora — Desktop", 10, 2, 2, 4 },
                    { 11, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Instalação de driver de impressora — Notebook", 11, 1, 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_EquipamentoId",
                table: "Chamados",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_SetorId",
                table: "Chamados",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_TipoServicoId",
                table: "Chamados",
                column: "TipoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_SetorId",
                table: "Equipamentos",
                column: "SetorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "TiposServico");

            migrationBuilder.DropTable(
                name: "Setores");
        }
    }
}
