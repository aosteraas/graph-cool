using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BagelGram.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "UserName" },
                values: new object[] { 1, new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bagel" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 1, "/uploads/2019-11-19-at-5.17.46.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 2, "/uploads/2019-11-19-at-5.18.30.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 3, "/uploads/2019-11-19-at-5.19.01.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 4, "/uploads/2019-11-19-at-5.19.40.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 5, "/uploads/2019-11-19-at-5.20.02.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 6, "/uploads/2019-11-19-at-5.20.28.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 7, "/uploads/2019-11-19-at-5.20.45.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 8, "/uploads/2019-11-19-at-5.21.00.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 9, "/uploads/2019-11-19-at-5.21.26.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Source", "Uploaded", "UserId" },
                values: new object[] { 10, "/uploads/2019-11-19-at-5.21.52.png", new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
