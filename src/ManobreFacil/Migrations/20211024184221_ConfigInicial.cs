using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManobreFacil.Migrations
{
    public partial class ConfigInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manobristas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manobristas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manobras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManobristaId = table.Column<int>(type: "int", nullable: false),
                    CarroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manobras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manobras_Carros_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Manobras_Manobristas_ManobristaId",
                        column: x => x.ManobristaId,
                        principalTable: "Manobristas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manobras_CarroId",
                table: "Manobras",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Manobras_ManobristaId",
                table: "Manobras",
                column: "ManobristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manobras");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Manobristas");
        }
    }
}
