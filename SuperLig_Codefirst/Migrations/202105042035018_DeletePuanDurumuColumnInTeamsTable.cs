namespace SuperLig_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePuanDurumuColumnInTeamsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Antrenors", "TakimI", c => c.String());
            AddColumn("dbo.Antrenors", "Ulke", c => c.String());
            DropColumn("dbo.Antrenors", "TakimId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Antrenors", "TakimId", c => c.Int(nullable: false));
            DropColumn("dbo.Antrenors", "Ulke");
            DropColumn("dbo.Antrenors", "TakimI");
        }
    }
}
