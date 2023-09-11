﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parkview.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationDescription",
                value: "Tourists flock to the Gateway of India to admire its Indo-Saracenic architecture and relive the city's colonial past with ParkView Maharashtra chains of hotels,Parkview Mumbai.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationDescription",
                value: "Tourists flock to the Gateway of India to admire its Indo-Saracenic architecture and relive the city's colonial past with ParkView Maharashtra.");
        }
    }
}
