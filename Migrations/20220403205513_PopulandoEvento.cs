using Microsoft.EntityFrameworkCore.Migrations;

namespace MVChallenge.Migrations
{
    public partial class PopulandoEvento : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Eventos(evento, Capacidade, Data, ValorIngresso, EstiloID, CasaShowID, Status) Values('Primavera', 100, STR_TO_DATE('12-12-2022', '%m-%d-%Y'), 200.00, 1, 1, 1)");
            mb.Sql("INSERT INTO Eventos(evento, Capacidade, Data, ValorIngresso, EstiloID, CasaShowID, Status) Values('KPOP DAY', 300, STR_TO_DATE('08-07-2022', '%m-%d-%Y'), 600.00, 2, 2, 1)");
            mb.Sql("INSERT INTO Eventos(evento, Capacidade, Data, ValorIngresso, EstiloID, CasaShowID, Status) Values('Metal', 200, STR_TO_DATE('12-05-2021', '%m-%d-%Y'), 400.00, 3, 3, 1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM CasaShows");
        }
    }
}
