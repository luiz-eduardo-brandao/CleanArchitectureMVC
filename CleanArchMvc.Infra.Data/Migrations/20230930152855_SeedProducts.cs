using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "VALUES('Caderno espiral', 'Caderno espiral 100 folhas', 7.45,50, 'caderno1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "VALUES('Estojo escolar', 'Estojo escolar cinza', 5.65,50, 'estojo1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "VALUES('Borracha escolar', 'Borraca branca pequena', 3.25,50, 'borracha1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "VALUES('Calculadora escolar', 'Calcularoda simples', 15.39,50, 'calculadora1.jpg', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
