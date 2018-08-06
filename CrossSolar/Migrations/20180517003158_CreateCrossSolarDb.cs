using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossSolar.Migrations
{
    public partial class CreateCrossSolarDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "OneHourElectricitys",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(nullable: false),
                    KiloWatt = table.Column<long>(nullable: false),
                    PanelId = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_OneHourElectricitys", x => x.Id); });

            migrationBuilder.CreateTable(
                "Panels",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Serial = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Panels", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "OneHourElectricitys");

            migrationBuilder.DropTable(
                "Panels");
        }
    }
}