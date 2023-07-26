using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusHealthSolutionsTeste1.Migrations
{
    public partial class FocusHealthSolutions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planilha",
                columns: table => new
                {
                    Ficha = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),                   
                    Agendado_Em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Parceiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Natureza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agendado_Para = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conf = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Pres = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ASO_Up = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ASO_Prot = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Pend = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Tem_Av = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Tem_Res = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planilha", x => x.Ficha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planilha");
        }
    }
}
