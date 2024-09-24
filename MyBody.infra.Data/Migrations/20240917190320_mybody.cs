using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBody.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class mybody : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyFat = table.Column<double>(type: "float", nullable: false),
                    BodyMass = table.Column<double>(type: "float", nullable: false),
                    BodyWanter = table.Column<double>(type: "float", nullable: false),
                    WeightBone = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasureChest = table.Column<double>(type: "float", nullable: false),
                    MeasureShoulders = table.Column<double>(type: "float", nullable: false),
                    MeasureLeftArm = table.Column<double>(type: "float", nullable: false),
                    MeasureRightArm = table.Column<double>(type: "float", nullable: false),
                    MeasureLeftForeArm = table.Column<double>(type: "float", nullable: false),
                    MeasureRightForeArm = table.Column<double>(type: "float", nullable: false),
                    MeasureAbs = table.Column<double>(type: "float", nullable: false),
                    MeasureLeftThigh = table.Column<double>(type: "float", nullable: false),
                    MeasureRightThigh = table.Column<double>(type: "float", nullable: false),
                    MeasureLeftCalf = table.Column<double>(type: "float", nullable: false),
                    MeasureRightCalf = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyCompositionId = table.Column<int>(type: "int", nullable: false),
                    BodyMeasurementsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Compositions_BodyCompositionId",
                        column: x => x.BodyCompositionId,
                        principalTable: "Compositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Measurements_BodyMeasurementsId",
                        column: x => x.BodyMeasurementsId,
                        principalTable: "Measurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BodyCompositionId",
                table: "Users",
                column: "BodyCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BodyMeasurementsId",
                table: "Users",
                column: "BodyMeasurementsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Compositions");

            migrationBuilder.DropTable(
                name: "Measurements");
        }
    }
}
