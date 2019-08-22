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
                    DespesasFarmacia = table.Column<decimal>(nullable: false),
                    ValorPorDia = table.Column<double>(nullable: false),
                    ValorPorPessoa = table.Column<double>(nullable: false)
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
                    TipoViagem = table.Column<int>(nullable: false),
                    MeioTransporte = table.Column<int>(nullable: false),
                    MotivoViagem = table.Column<int>(nullable: false),
                    Ida = table.Column<DateTime>(nullable: false),
                    Volta = table.Column<DateTime>(nullable: false),
                    QtdeDias = table.Column<int>(nullable: false),
                    QtdeViajantes = table.Column<int>(nullable: false),
                    DestinoId = table.Column<int>(nullable: false),
                    OrigemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacoes", x => x.CotId);
                    table.ForeignKey(
                        name: "FK_Cotacoes_Estados_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Estados",
                        principalColumn: "EstadoId");
                    table.ForeignKey(
                        name: "FK_Cotacoes_Estados_OrigemId",
                        column: x => x.OrigemId,
                        principalTable: "Estados",
                        principalColumn: "EstadoId");
                });

            migrationBuilder.CreateTable(
                name: "AcrescimosMeioTransporte",
                columns: table => new
                {
                    TransporteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegId = table.Column<int>(nullable: false),
                    MeioTransporte = table.Column<int>(nullable: false),
                    AcrescimoTransporte = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcrescimosMeioTransporte", x => x.TransporteId);
                    table.ForeignKey(
                        name: "FK_AcrescimosMeioTransporte_Seguradoras_SegId",
                        column: x => x.SegId,
                        principalTable: "Seguradoras",
                        principalColumn: "SegId");
                });

            migrationBuilder.CreateTable(
                name: "AcrescimosMotivoViagem",
                columns: table => new
                {
                    MotivoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegId = table.Column<int>(nullable: false),
                    MotivoViagem = table.Column<int>(nullable: false),
                    AcrescimoMotivo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcrescimosMotivoViagem", x => x.MotivoId);
                    table.ForeignKey(
                        name: "FK_AcrescimosMotivoViagem_Seguradoras_SegId",
                        column: x => x.SegId,
                        principalTable: "Seguradoras",
                        principalColumn: "SegId");
                });

            migrationBuilder.CreateTable(
                name: "AcrescimosTipoViagem",
                columns: table => new
                {
                    TipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegId = table.Column<int>(nullable: false),
                    TipoViagem = table.Column<int>(nullable: false),
                    AcrescimoViagem = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcrescimosTipoViagem", x => x.TipoId);
                    table.ForeignKey(
                        name: "FK_AcrescimosTipoViagem_Seguradoras_SegId",
                        column: x => x.SegId,
                        principalTable: "Seguradoras",
                        principalColumn: "SegId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcrescimosMeioTransporte_SegId",
                table: "AcrescimosMeioTransporte",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_AcrescimosMotivoViagem_SegId",
                table: "AcrescimosMotivoViagem",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_AcrescimosTipoViagem_SegId",
                table: "AcrescimosTipoViagem",
                column: "SegId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_DestinoId",
                table: "Cotacoes",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_OrigemId",
                table: "Cotacoes",
                column: "OrigemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcrescimosMeioTransporte");

            migrationBuilder.DropTable(
                name: "AcrescimosMotivoViagem");

            migrationBuilder.DropTable(
                name: "AcrescimosTipoViagem");

            migrationBuilder.DropTable(
                name: "Cotacoes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Seguradoras");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
