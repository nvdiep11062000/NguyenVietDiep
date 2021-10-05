namespace NguyenVietDiep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _class : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SinhViens");
            AlterColumn("dbo.LopHocs", "TenLop", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SinhViens", "MaSinhVien", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.SinhViens", "HoTen", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.SinhViens", "MaSinhVien");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SinhViens");
            AlterColumn("dbo.SinhViens", "HoTen", c => c.String());
            AlterColumn("dbo.SinhViens", "MaSinhVien", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.LopHocs", "TenLop", c => c.String(unicode: false));
            AddPrimaryKey("dbo.SinhViens", "MaSinhVien");
        }
    }
}
