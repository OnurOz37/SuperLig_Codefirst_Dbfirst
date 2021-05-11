namespace SuperLig_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTrainersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Antrenors",
                c => new
                    {
                        AntrenorId = c.Int(nullable: false, identity: true),
                        AntrenorAdi = c.String(),
                        TakimId = c.Int(nullable: false),
                        Yas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AntrenorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Antrenors");
        }
    }
}
