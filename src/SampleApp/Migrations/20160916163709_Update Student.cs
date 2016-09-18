using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleApp.Migrations
{
    public partial class UpdateStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FristName",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "FristName",
                table: "Student",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
