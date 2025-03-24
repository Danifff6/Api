using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDanielLucas.Migrations
{
    /// <inheritdoc />
    public partial class Etec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aluno",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricula = table.Column<int>(type: "int", nullable: false),
                    pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    escola_id = table.Column<int>(type: "int", nullable: false),
                    professor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluno", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "escola",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aluno_id = table.Column<int>(type: "int", nullable: false),
                    professor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escola", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "professor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricula = table.Column<int>(type: "int", nullable: false),
                    pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    escola_id = table.Column<int>(type: "int", nullable: false),
                    componente_curricular = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professor", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aluno");

            migrationBuilder.DropTable(
                name: "escola");

            migrationBuilder.DropTable(
                name: "professor");
        }
    }
}
