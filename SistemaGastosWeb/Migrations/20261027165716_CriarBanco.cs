using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGastosWeb.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GanhoDiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKUsuario = table.Column<int>(type: "int", nullable: false),
                    ValorDoDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GanhoDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GanhoDiario_Usuario_FKUsuario",
                        column: x => x.FKUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GastoDiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKUsuario = table.Column<int>(type: "int", nullable: false),
                    ValorDoDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastoDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GastoDiario_Usuario_FKUsuario",
                        column: x => x.FKUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GanhoDiario_FKUsuario",
                table: "GanhoDiario",
                column: "FKUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_GastoDiario_FKUsuario",
                table: "GastoDiario",
                column: "FKUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GanhoDiario");

            migrationBuilder.DropTable(
                name: "GastoDiario");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
