using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Datalayer.Migrations
{
    public partial class makedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Category = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Color = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AvailableQuantity = table.Column<long>(nullable: false),
                    ProductImagePath = table.Column<string>(unicode: false, nullable: true),
                    Companies = table.Column<string>(nullable: true),
                    CratedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__B40CC6CD7886E05E", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
