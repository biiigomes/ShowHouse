using Microsoft.EntityFrameworkCore.Migrations;

namespace MVChallenge.Migrations
{
    public partial class PopulandoCasaShow : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO CasaShows(Nome, Endereco, Status) Values('Casa Suave', 'Rua Curitiba', 1)");
            mb.Sql("INSERT INTO CasaShows(Nome, Endereco, Status) Values('Casa Eclética', 'Rua São Paulo', 1)");
            mb.Sql("INSERT INTO CasaShows(Nome, Endereco, Status) Values('Casa Metal', 'Rua Sydney', 1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM CasaShows");
        }
    }
}
