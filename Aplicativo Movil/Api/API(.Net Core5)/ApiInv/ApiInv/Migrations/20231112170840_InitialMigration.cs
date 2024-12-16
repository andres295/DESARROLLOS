using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiInv.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    ARTICULO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROVEEDOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.ARTICULO);
                });

            migrationBuilder.CreateTable(
                name: "Inventa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Conteo1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo7 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo9 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo11 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo12 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo13 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo14 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conteo15 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bodega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Um = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User15 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UBICACION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Inventa_InventaId",
                        column: x => x.InventaId,
                        principalTable: "Inventa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_InventaId",
                table: "Ubicaciones",
                column: "InventaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Inventa");
        }
    }
}
