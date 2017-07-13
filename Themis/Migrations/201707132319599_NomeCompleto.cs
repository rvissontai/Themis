namespace Themis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeCompleto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "NomeCompleto", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "NomeCompleto");
        }
    }
}
