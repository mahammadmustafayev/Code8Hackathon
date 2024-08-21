using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackathonPrep.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "Applicants",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Applicants");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }
    }
}
