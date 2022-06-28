using Microsoft.EntityFrameworkCore.Migrations;

namespace MVChallenge.Migrations
{
    public partial class PopulandoEstilo : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Estilos(EstiloMusical, ImagemCaminho, Status) VALUES('Classico', 'classico.jpg', 1)");
            mb.Sql("INSERT INTO Estilos(EstiloMusical, ImagemCaminho, Status) VALUES('Pop', 'pop.jpg', 1)");
            mb.Sql("INSERT INTO Estilos(EstiloMusical, ImagemCaminho, Status) VALUES('Rock', 'rock.jpg', 1)");
            mb.Sql("INSERT INTO Estilos(EstiloMusical, ImagemCaminho, Status) VALUES('Sertanejo', 'sertanejo.jpg', 1)");
            mb.Sql("INSERT INTO Estilos(EstiloMusical, ImagemCaminho, Status) VALUES('Disco', 'disco.jpg', 1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Estilos");
        } 
    }
}
