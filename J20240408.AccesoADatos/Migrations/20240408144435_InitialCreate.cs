using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace J20240408.AccesoADatos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personasJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoJ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechadeNacimientoJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoJ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estatus = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personasJ", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personasJ");
        }
    }
}
