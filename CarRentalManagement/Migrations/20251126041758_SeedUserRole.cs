using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d6960df6-bca6-4078-b9c3-c0deab25959c", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOylC3u+KT37ONeO8JunmgGqNu40EM19rxXAldc4L3O23Xd5z4nw8ezU9YZOvF1BFw==", null, false, "94673844-c06d-4566-b9be-b2dae8a3762c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8154), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8175), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8650), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8653), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8501), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8506), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8508), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8510), new DateTime(2025, 11, 26, 12, 17, 56, 692, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8583), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8597), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8804), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8740), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8742), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8743), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8745), new DateTime(2025, 11, 26, 11, 32, 52, 959, DateTimeKind.Local).AddTicks(8745) });
        }
    }
}
