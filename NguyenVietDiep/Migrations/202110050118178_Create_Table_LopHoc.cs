namespace NguyenVietDiep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LopHoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHocs");
        }
    }
}
