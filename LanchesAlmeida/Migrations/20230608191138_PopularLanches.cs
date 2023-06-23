using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesAlmeida.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, Carne, Queijo e Molho Especial','Delicioso hambúrguer com queijo de primeira qualidade para sua criança.',1,'https://drive.google.com/file/d/1LrV_jN9rw9uM9TbXPXx8L_iBiko2648m/view?usp=drive_link','https://drive.google.com/file/d/1LrV_jN9rw9uM9TbXPXx8L_iBiko2648m/view?usp=drive_link',0,'Cheese KIDS',12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, Carne, Ovo, Presunto, Queijo, Bacon, Alface, Tomate e Molho Especial','Delicioso hambúrguer com queijo, presunto e bacon de primeira qualidade para matar sua fome.',1,'https://drive.google.com/file/d/1-_V9ASFvzQbbeig3uHAD3_y_qJiYEopU/view?usp=drive_link','https://drive.google.com/file/d/1-_V9ASFvzQbbeig3uHAD3_y_qJiYEopU/view?usp=drive_link',0,'X EGG BACON',8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, Carne, Queijo, Presunto, Calabresa, Alface, Tomate e Molho Especial','Delicioso hambúrguer com queijo, presunto e calabresa de primeira qualidade para matar sua fome.',1,'https://drive.google.com/file/d/1Z8LymflxGHv7CYMZDd-xjmIAYDKhD1Iy/view?usp=drive_link','https://drive.google.com/file/d/1Z8LymflxGHv7CYMZDd-xjmIAYDKhD1Iy/view?usp=drive_link',0,'X CALABRESA',11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão Artesanal Com Gergelim, 3 Hambúrgueres Bovino Artesanal 100g, Cheddar, Bacon, Alface Americana, Tomate, Cebola Roxa, e Molho Especial','Delicioso hambúrguer triplo artesanal com queijo cheddar e bacon de primeira qualidade para matar sua fome.',1,'https://drive.google.com/file/d/136L33a0bXFDN5QAdlhrbMRHmbZllouBx/view?usp=drive_link','https://drive.google.com/file/d/136L33a0bXFDN5QAdlhrbMRHmbZllouBx/view?usp=drive_link',1,'TRIPLO ARTESANAL', 25.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
