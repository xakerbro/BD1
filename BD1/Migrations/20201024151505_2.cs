using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD1.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Dop_yslygiID",
                table: "Prokat",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "KlientiID",
                table: "Prokat",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SotrudnikiID",
                table: "Prokat",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SotrudnikiID",
                table: "Avtomobili",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Doljnosti",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie_doljnosti = table.Column<string>(nullable: true),
                    Oklad = table.Column<int>(nullable: false),
                    Trebovaniya = table.Column<string>(nullable: true),
                    Obyazanosti = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doljnosti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dop_yslygi",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(nullable: true),
                    Opisanie = table.Column<string>(nullable: true),
                    Cena = table.Column<int>(nullable: false),
                    Kod_prokata = table.Column<long>(nullable: false),
                    Kod_yslygi_3Kod_prokata = table.Column<long>(nullable: false),
                    Kod_yslygi_2Kod_prokata = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dop_yslygi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Klienti",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Pol = table.Column<int>(nullable: false),
                    Data_rojdenia = table.Column<DateTime>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    Pasportnie_dannie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sotrudniki",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Vozrast = table.Column<int>(nullable: false),
                    Pol = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    Pasportnie_dannie = table.Column<string>(nullable: true),
                    DoljnostiID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotrudniki", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sotrudniki_Doljnosti_DoljnostiID",
                        column: x => x.DoljnostiID,
                        principalTable: "Doljnosti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prokat_Dop_yslygiID",
                table: "Prokat",
                column: "Dop_yslygiID");

            migrationBuilder.CreateIndex(
                name: "IX_Prokat_KlientiID",
                table: "Prokat",
                column: "KlientiID");

            migrationBuilder.CreateIndex(
                name: "IX_Prokat_SotrudnikiID",
                table: "Prokat",
                column: "SotrudnikiID");

            migrationBuilder.CreateIndex(
                name: "IX_Avtomobili_SotrudnikiID",
                table: "Avtomobili",
                column: "SotrudnikiID");

            migrationBuilder.CreateIndex(
                name: "IX_Sotrudniki_DoljnostiID",
                table: "Sotrudniki",
                column: "DoljnostiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Avtomobili_Sotrudniki_SotrudnikiID",
                table: "Avtomobili",
                column: "SotrudnikiID",
                principalTable: "Sotrudniki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prokat_Dop_yslygi_Dop_yslygiID",
                table: "Prokat",
                column: "Dop_yslygiID",
                principalTable: "Dop_yslygi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prokat_Klienti_KlientiID",
                table: "Prokat",
                column: "KlientiID",
                principalTable: "Klienti",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prokat_Sotrudniki_SotrudnikiID",
                table: "Prokat",
                column: "SotrudnikiID",
                principalTable: "Sotrudniki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avtomobili_Sotrudniki_SotrudnikiID",
                table: "Avtomobili");

            migrationBuilder.DropForeignKey(
                name: "FK_Prokat_Dop_yslygi_Dop_yslygiID",
                table: "Prokat");

            migrationBuilder.DropForeignKey(
                name: "FK_Prokat_Klienti_KlientiID",
                table: "Prokat");

            migrationBuilder.DropForeignKey(
                name: "FK_Prokat_Sotrudniki_SotrudnikiID",
                table: "Prokat");

            migrationBuilder.DropTable(
                name: "Dop_yslygi");

            migrationBuilder.DropTable(
                name: "Klienti");

            migrationBuilder.DropTable(
                name: "Sotrudniki");

            migrationBuilder.DropTable(
                name: "Doljnosti");

            migrationBuilder.DropIndex(
                name: "IX_Prokat_Dop_yslygiID",
                table: "Prokat");

            migrationBuilder.DropIndex(
                name: "IX_Prokat_KlientiID",
                table: "Prokat");

            migrationBuilder.DropIndex(
                name: "IX_Prokat_SotrudnikiID",
                table: "Prokat");

            migrationBuilder.DropIndex(
                name: "IX_Avtomobili_SotrudnikiID",
                table: "Avtomobili");

            migrationBuilder.DropColumn(
                name: "Dop_yslygiID",
                table: "Prokat");

            migrationBuilder.DropColumn(
                name: "KlientiID",
                table: "Prokat");

            migrationBuilder.DropColumn(
                name: "SotrudnikiID",
                table: "Prokat");

            migrationBuilder.DropColumn(
                name: "SotrudnikiID",
                table: "Avtomobili");
        }
    }
}
