namespace SuperLig_Codefirst.Migrations
{
    using SuperLig_Codefirst.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Takims",
                c => new
                {
                    TakimId = c.Int(nullable: false, identity: true),
                    TakimAd = c.String(),
                    KurulusTarihi = c.String(),
                    
                    AntrenorAdi = c.String(),
                })
                .PrimaryKey(t => t.TakimId);

        }

        public override void Down()
        {
            DropTable("dbo.Takims");
        }



       
        
       }
}
