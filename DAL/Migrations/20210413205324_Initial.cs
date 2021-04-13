using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Airplane",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Airplane", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "City",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_City", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Flight",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AirplaneID = table.Column<int>(type: "int", nullable: false),
            //        StartCityID = table.Column<int>(type: "int", nullable: true),
            //        FinishCityID = table.Column<int>(type: "int", nullable: true),
            //        Time = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Flight", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Flight_Airplane_AirplaneID",
            //            column: x => x.AirplaneID,
            //            principalTable: "Airplane",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Flight_City_FinishCityID",
            //            column: x => x.FinishCityID,
            //            principalTable: "City",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Flight_City_StartCityID",
            //            column: x => x.StartCityID,
            //            principalTable: "City",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Flight_AirplaneID",
            //    table: "Flight",
            //    column: "AirplaneID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Flight_FinishCityID",
            //    table: "Flight",
            //    column: "FinishCityID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Flight_StartCityID",
            //    table: "Flight",
            //    column: "StartCityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Airplane");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
