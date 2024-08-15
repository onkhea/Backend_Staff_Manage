﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staff_Management.Migrations
{
    public partial class InicialCreare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
