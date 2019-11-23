using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BagelGram.Data.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "Images",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Probably almost Bagel's first day home", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Chew toy on the head", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Smushed head dog", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "First lazy sit captured", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "And onto her second collar", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Frowning head bagel", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "World's most forlorn dog", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Needy ass dog", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "She used to fit on a chair", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Caption", "Uploaded" },
                values: new object[] { "Deer-ear dog", new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caption",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Uploaded",
                value: new DateTime(2019, 11, 9, 17, 49, 8, 573, DateTimeKind.Local).AddTicks(8610));
        }
    }
}
