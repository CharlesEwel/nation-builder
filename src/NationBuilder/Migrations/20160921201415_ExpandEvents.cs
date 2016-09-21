using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationBuilder.Migrations
{
    public partial class ExpandEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Choice1Cap",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Choice1Outcome",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Choice2Cap",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Choice2Outcome",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Choice3Cap",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Choice3Outcome",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Choice1Cap",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Choice1Outcome",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Choice2Cap",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Choice2Outcome",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Choice3Cap",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Choice3Outcome",
                table: "Events");
        }
    }
}
