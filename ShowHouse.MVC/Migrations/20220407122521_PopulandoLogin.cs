using Microsoft.EntityFrameworkCore.Migrations;

namespace MVChallenge.Migrations
{
    public partial class PopulandoLogin : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Logins(Nome, UserName, Senha, Status) Values('Admin', 'Admin', 'Admin', 1)");
            mb.Sql("INSERT INTO Logins(Nome, UserName, Senha, Status) Values('Tony Stark', 'HomemDeFerro', 'Playboyzinho', 1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Logins");
        }
    }
}
