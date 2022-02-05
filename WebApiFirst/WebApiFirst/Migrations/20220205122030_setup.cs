using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiFirst.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Date", "FirstName", "LastName", "Phone" },
                values: new object[] { 1, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Nowak", "122323232" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Date", "FirstName", "LastName", "Phone" },
                values: new object[] { 2, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monika", "Małecka", "4433333" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Date", "FirstName", "LastName", "Phone" },
                values: new object[] { 3, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teresa", "Tur", "555533333" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Date", "FirstName", "LastName", "Phone" },
                values: new object[] { 4, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasz", "Bomasz", "467777777" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
