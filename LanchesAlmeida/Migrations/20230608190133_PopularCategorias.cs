using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesAlmeida.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Burguers Tradicionais','Hambúrguers feito com ingredientes de primeira')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Hambúrguers Artesanais','Hambúrguers feito com carnes artesanais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Bebidas','Bebidas diversas')");
        }
    

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
