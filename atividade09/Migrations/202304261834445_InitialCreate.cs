namespace atividade09.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invertebrados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        classe = c.String(),
                        categoria = c.String(),
                        exoesqueleto = c.String(),
                        tamanho_centimetros = c.String(),
                        nome = c.String(),
                        regiao = c.String(),
                        familia = c.String(),
                        quantidade_patas = c.String(),
                        anfibio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vertebrados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tem_pelos = c.String(),
                        raca = c.String(),
                        penas = c.String(),
                        tamanho_metros = c.String(),
                        nome = c.String(),
                        regiao = c.String(),
                        familia = c.String(),
                        quantidade_patas = c.String(),
                        anfibio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vertebrados");
            DropTable("dbo.Invertebrados");
        }
    }
}
