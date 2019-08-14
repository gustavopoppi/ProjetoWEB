using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguroViagem.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estados = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Seguradoras",
                columns: table => new
                {
                    SegId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeSeg = table.Column<string>(nullable: false),
                    Comissao = table.Column<int>(nullable: false),
                    ExtBagagem = table.Column<decimal>(nullable: false),
                    MorteAcid = table.Column<decimal>(nullable: false),
                    TransCorpo = table.Column<decimal>(nullable: false),
                    InvalidezPerm = table.Column<decimal>(nullable: false),
                    DespesasFarmacia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguradoras", x => x.SegId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Cotacoes",
                columns: table => new
                {
                    CotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoViagem = table.Column<string>(nullable: true),
                    MeioTransporte = table.Column<string>(nullable: false),
                    MotivoViagem = table.Column<string>(nullable: false),
                    Ida = table.Column<DateTime>(nullable: false),
                    Volta = table.Column<DateTime>(nullable: false),
                    QtdeDias = table.Column<int>(nullable: false),
                    QtdeViajantes = table.Column<string>(nullable: false),
                    DestinoId = table.Column<int>(nullable: false),
                    OrigemId = table.Column<int>(nullable: false),
                    //EstadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacoes", x => x.CotId);
                    //table.ForeignKey(
                    //    name: "FK_Cotacoes_Estados_EstadoId",
                    //    column: x => x.EstadoId,
                    //    principalTable: "Estados",
                    //    principalColumn: "EstadoId",
                    //    onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cotacoes_EstadoId",
            //    table: "Cotacoes",
            //    column: "EstadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotacoes");

            migrationBuilder.DropTable(
                name: "Seguradoras");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
