using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day_05.Migrations
{
    public partial class InitialAddFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Posts");
        }
    }
}
