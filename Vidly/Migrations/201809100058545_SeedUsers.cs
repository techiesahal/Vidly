namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'10ab2600-b585-4955-a662-95346c219e91', N'admin@vidly.com', 0, N'AMfVZIYC/FdaYhy/4rNj4TC+Luo/wOYvZU6vo3Wv4G2inDvNVR3Vil0MkFVkmjrybQ==', N'e121e726-b393-4816-8707-de22d785e161', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2234734-7b77-482e-9f2e-dbf1144059e3', N'guest@vidly.com', 0, N'AB62v1wZ2CcgDqfuPMNWBW9pvhk2380MfZpJICIllUDYiqnjoFJ2qkGx9teMAemNCg==', N'9c9d9e33-30bd-49e8-989a-56ba2cde1a5a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a1be01f5-fbfb-4990-800a-5da2eac45221', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'10ab2600-b585-4955-a662-95346c219e91', N'a1be01f5-fbfb-4990-800a-5da2eac45221')
");
        }
        
        public override void Down()
        {
        }
    }
}
