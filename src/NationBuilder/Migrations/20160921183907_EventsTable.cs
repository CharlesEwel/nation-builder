using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NationBuilder.Migrations
{
    public partial class EventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Chocie1Res = table.Column<int>(nullable: false),
                    Chocie2Res = table.Column<int>(nullable: false),
                    Chocie3Res = table.Column<int>(nullable: false),
                    Choice1Pop = table.Column<int>(nullable: false),
                    Choice1Stab = table.Column<int>(nullable: false),
                    Choice1Words = table.Column<string>(nullable: true),
                    Choice2Pop = table.Column<int>(nullable: false),
                    Choice2Stab = table.Column<int>(nullable: false),
                    Choice2Words = table.Column<string>(nullable: true),
                    Choice3Pop = table.Column<int>(nullable: false),
                    Choice3Stab = table.Column<int>(nullable: false),
                    Choice3Words = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
