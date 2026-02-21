using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputergyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOPTtoPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationOTP",
                table: "Persons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OTP",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationOTP",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OTP",
                table: "Persons");
        }
    }
}
