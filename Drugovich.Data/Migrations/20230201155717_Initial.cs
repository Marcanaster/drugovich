using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drugovich.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Gerente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nivel = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GerenteRef = table.Column<int>(type: "int", nullable: false),
                    CreatAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Gerente_GerenteRef",
                        column: x => x.GerenteRef,
                        principalTable: "Gerente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataFundacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GrupoRef = table.Column<int>(type: "int", nullable: false),
                    CreatAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Grupo_GrupoRef",
                        column: x => x.GrupoRef,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Gerente",
                columns: new[] { "Id", "Codigo", "CreatAt", "Email", "Nome", "UpdateAt" },
                values: new object[] { 1, "GR0001", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5943), "gerentenivel1@drugovich.com", "Gerente nivel Um", null });

            migrationBuilder.InsertData(
                table: "Gerente",
                columns: new[] { "Id", "Codigo", "CreatAt", "Email", "Nivel", "Nome", "UpdateAt" },
                values: new object[] { 2, "GR0002", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5974), "gerentenivel2@drugovich.com", 1, "Gerente nivel Dois", null });

            migrationBuilder.InsertData(
                table: "Grupo",
                columns: new[] { "Id", "Codigo", "CreatAt", "Nome", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Grupo000A", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5986), "Grupo A", null },
                    { 2, "Grupo000B", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(5994), "Grupo B", null },
                    { 3, "Grupo000C", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6000), "Grupo C", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CNPJ", "Codigo", "CreatAt", "DataFundacao", "GrupoRef", "Nome", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "95195019000147", "CLiente0001", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6008), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cliente 1", null },
                    { 2, "43514821000159", "CLiente0002", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6015), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cliente 2", null },
                    { 3, "15693178000132", "CLiente0003", new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6021), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Cliente 3", null }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Ativo", "CreatAt", "GerenteRef", "Login", "Senha", "UpdateAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6032), 1, "user1", "0a84e19c7d8defe8", null },
                    { 2, true, new DateTime(2023, 2, 1, 12, 57, 17, 785, DateTimeKind.Local).AddTicks(6040), 2, "user2", "0a84e19c7d8defe8", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Codigo",
                table: "Cliente",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_GrupoRef",
                table: "Cliente",
                column: "GrupoRef");

            migrationBuilder.CreateIndex(
                name: "IX_Gerente_Codigo",
                table: "Gerente",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gerente_Email",
                table: "Gerente",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_Codigo",
                table: "Grupo",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_GerenteRef",
                table: "Usuario",
                column: "GerenteRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Login",
                table: "Usuario",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Gerente");
        }
    }
}
