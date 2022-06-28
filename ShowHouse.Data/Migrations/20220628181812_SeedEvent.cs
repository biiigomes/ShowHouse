using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowHouse.Data.Migrations
{
    public partial class SeedEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Events(name, capacity, date, ticketvalue, styleid, showhouseid, status) VALUES ('Sofrencias', 100, '21/10/2022', 150.00, 1, 3, 1)");
            migrationBuilder.Sql("INSERT INTO Events(name, capacity, date, ticketvalue, styleid, showhouseid, status) VALUES ('Primavera', 50, '10/12/2022', 200.00, 2, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Events(name, capacity, date, ticketvalue, styleid, showhouseid, status) VALUES ('Korea in Brazil', 200, '05/11/2022', 500.00, 3, 3, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Events");
        }
    }
}
