namespace SuperLig_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePuanDurumuColumnInTeamsTable2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Takims", "PuanDurumu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Takims", "PuanDurumu", c => c.Int(nullable: false));
        }
    }
}
