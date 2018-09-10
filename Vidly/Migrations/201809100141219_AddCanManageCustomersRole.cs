namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCanManageCustomersRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9de73d7e-7b72-4690-953d-b4f2c49f22c8', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'10ab2600-b585-4955-a662-95346c219e91', N'9de73d7e-7b72-4690-953d-b4f2c49f22c8')
");
        }
        
        public override void Down()
        {
        }
    }
}
