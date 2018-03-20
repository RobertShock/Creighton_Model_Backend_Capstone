using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Creighton_Model_App.Data.Migrations
{
    public partial class changedChart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Charts_ChartId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Stickers_Charts_ChartId",
                table: "Stickers");

            migrationBuilder.DropIndex(
                name: "IX_Stickers_ChartId",
                table: "Stickers");

            migrationBuilder.DropIndex(
                name: "IX_Descriptions_ChartId",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "ChartId",
                table: "Stickers");

            migrationBuilder.DropColumn(
                name: "ChartId",
                table: "Descriptions");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Stickers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Descriptions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Charts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Charts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StickerId",
                table: "Charts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Charts_DescriptionId",
                table: "Charts",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Charts_StickerId",
                table: "Charts",
                column: "StickerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Charts_Descriptions_DescriptionId",
                table: "Charts",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Charts_Stickers_StickerId",
                table: "Charts",
                column: "StickerId",
                principalTable: "Stickers",
                principalColumn: "StickerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charts_Descriptions_DescriptionId",
                table: "Charts");

            migrationBuilder.DropForeignKey(
                name: "FK_Charts_Stickers_StickerId",
                table: "Charts");

            migrationBuilder.DropIndex(
                name: "IX_Charts_DescriptionId",
                table: "Charts");

            migrationBuilder.DropIndex(
                name: "IX_Charts_StickerId",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Stickers");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "StickerId",
                table: "Charts");

            migrationBuilder.AddColumn<int>(
                name: "ChartId",
                table: "Stickers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChartId",
                table: "Descriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stickers_ChartId",
                table: "Stickers",
                column: "ChartId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ChartId",
                table: "Descriptions",
                column: "ChartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Charts_ChartId",
                table: "Descriptions",
                column: "ChartId",
                principalTable: "Charts",
                principalColumn: "ChartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stickers_Charts_ChartId",
                table: "Stickers",
                column: "ChartId",
                principalTable: "Charts",
                principalColumn: "ChartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
