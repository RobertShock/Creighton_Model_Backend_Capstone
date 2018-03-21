using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Creighton_Model_App.Data.Migrations
{
    public partial class CorrectedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChartsEnteries_Descriptions_DescriptionId",
                table: "ChartsEnteries");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartsEnteries_Stickers_StickerId",
                table: "ChartsEnteries");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartsEnteries_AspNetUsers_UserId",
                table: "ChartsEnteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChartsEnteries",
                table: "ChartsEnteries");

            migrationBuilder.RenameTable(
                name: "ChartsEnteries",
                newName: "ChartEnteries");

            migrationBuilder.RenameIndex(
                name: "IX_ChartsEnteries_UserId",
                table: "ChartEnteries",
                newName: "IX_ChartEnteries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ChartsEnteries_StickerId",
                table: "ChartEnteries",
                newName: "IX_ChartEnteries_StickerId");

            migrationBuilder.RenameIndex(
                name: "IX_ChartsEnteries_DescriptionId",
                table: "ChartEnteries",
                newName: "IX_ChartEnteries_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChartEnteries",
                table: "ChartEnteries",
                column: "ChartEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChartEnteries_Descriptions_DescriptionId",
                table: "ChartEnteries",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChartEnteries_Stickers_StickerId",
                table: "ChartEnteries",
                column: "StickerId",
                principalTable: "Stickers",
                principalColumn: "StickerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChartEnteries_AspNetUsers_UserId",
                table: "ChartEnteries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChartEnteries_Descriptions_DescriptionId",
                table: "ChartEnteries");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartEnteries_Stickers_StickerId",
                table: "ChartEnteries");

            migrationBuilder.DropForeignKey(
                name: "FK_ChartEnteries_AspNetUsers_UserId",
                table: "ChartEnteries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChartEnteries",
                table: "ChartEnteries");

            migrationBuilder.RenameTable(
                name: "ChartEnteries",
                newName: "ChartsEnteries");

            migrationBuilder.RenameIndex(
                name: "IX_ChartEnteries_UserId",
                table: "ChartsEnteries",
                newName: "IX_ChartsEnteries_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ChartEnteries_StickerId",
                table: "ChartsEnteries",
                newName: "IX_ChartsEnteries_StickerId");

            migrationBuilder.RenameIndex(
                name: "IX_ChartEnteries_DescriptionId",
                table: "ChartsEnteries",
                newName: "IX_ChartsEnteries_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChartsEnteries",
                table: "ChartsEnteries",
                column: "ChartEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChartsEnteries_Descriptions_DescriptionId",
                table: "ChartsEnteries",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChartsEnteries_Stickers_StickerId",
                table: "ChartsEnteries",
                column: "StickerId",
                principalTable: "Stickers",
                principalColumn: "StickerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChartsEnteries_AspNetUsers_UserId",
                table: "ChartsEnteries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
