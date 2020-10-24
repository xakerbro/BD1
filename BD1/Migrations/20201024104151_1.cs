using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD1.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avtomobili",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registr_nomer = table.Column<int>(nullable: false),
                    Nomer_kyzova = table.Column<int>(nullable: false),
                    Nomer_dvigatelya = table.Column<int>(nullable: false),
                    God_vipyska = table.Column<DateTime>(nullable: false),
                    Probeg = table.Column<int>(nullable: false),
                    Cena_avto = table.Column<int>(nullable: false),
                    Cena_dlya_prokata = table.Column<int>(nullable: false),
                    Data_poslednego_TO = table.Column<DateTime>(nullable: false),
                    Spec_otmetki = table.Column<string>(nullable: true),
                    Otmetka_o_vozraste = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avtomobili", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marki_avtomobiley",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(nullable: true),
                    Tech_harakteristiki = table.Column<string>(nullable: true),
                    Opisanie = table.Column<string>(nullable: true),
                    AvtomobiliID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marki_avtomobiley", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Marki_avtomobiley_Avtomobili_AvtomobiliID",
                        column: x => x.AvtomobiliID,
                        principalTable: "Avtomobili",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prokat",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_vidachi = table.Column<DateTime>(nullable: false),
                    Srok_prokata = table.Column<DateTime>(nullable: false),
                    Data_vozvrata = table.Column<DateTime>(nullable: false),
                    Cena_prokata = table.Column<int>(nullable: false),
                    Otmetka_ob_oplate = table.Column<string>(nullable: true),
                    AvtomobiliID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prokat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prokat_Avtomobili_AvtomobiliID",
                        column: x => x.AvtomobiliID,
                        principalTable: "Avtomobili",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marki_avtomobiley_AvtomobiliID",
                table: "Marki_avtomobiley",
                column: "AvtomobiliID");

            migrationBuilder.CreateIndex(
                name: "IX_Prokat_AvtomobiliID",
                table: "Prokat",
                column: "AvtomobiliID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marki_avtomobiley");

            migrationBuilder.DropTable(
                name: "Prokat");

            migrationBuilder.DropTable(
                name: "Avtomobili");
        }
    }
}
