using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital.Ventures.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("e7ab4813-12bb-4475-98c5-bc5160c6fd87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Harry Kane" },
                    { new Guid("5b7ed2d5-d619-421b-800e-ad71dbdf8578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egypt", "Mohamed Salah" },
                    { new Guid("3c7dfc35-6118-458b-a68d-2c9e0b74e69c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senegal", "Sadio Mane" },
                    { new Guid("c9963db3-95d2-4599-856b-ea2702344e10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Korea", "Son Heung-Min" },
                    { new Guid("4fae94e2-9e61-4a7b-8623-b8df35e0e3d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Trent Alexander-Arnold" },
                    { new Guid("2a98ffba-4d14-4cba-8ec4-bcc72bd101bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Harry Maguire" },
                    { new Guid("45d6fca6-1ae0-4876-be79-bc706cb3375e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Ben Chilwell" },
                    { new Guid("2f533d74-f741-47bb-9880-7c4e9fe1dd8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Ross Barkley" },
                    { new Guid("ea6f1a16-4412-478c-9e94-dcee296512a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Jack Grealish" },
                    { new Guid("7768331e-9cca-4347-a27e-1f42ce9b3e2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Tyrone Mings" },
                    { new Guid("a7aeb14c-4f5d-469c-8b55-83931b08f507"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Jack Tarkowski" },
                    { new Guid("ba17e1fa-22eb-4e03-9e5c-819afe0941e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "England", "Nick Pope" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
