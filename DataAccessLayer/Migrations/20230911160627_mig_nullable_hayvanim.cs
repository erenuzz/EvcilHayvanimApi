﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mignullablehayvanim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "hayvaniminBilgileris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklemeTarihi",
                table: "hayvaniminBilgileris",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                column: "EvcilHayvanlarId",
                principalTable: "EvcilHayvanlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "hayvaniminBilgileris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklemeTarihi",
                table: "hayvaniminBilgileris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                column: "EvcilHayvanlarId",
                principalTable: "EvcilHayvanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
