using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Omack.Data.Migrations
{
    public partial class AddedNavigationpropforNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Notifications_GroupId",
                table: "Notifications",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Groups_GroupId",
                table: "Notifications",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Groups_GroupId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_GroupId",
                table: "Notifications");
        }
    }
}
