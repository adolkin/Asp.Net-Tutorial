namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51b14893-8230-40fe-811f-103aa4bfaec6', N'admin@vidly.com', 0, N'ADXfGUyWbS9R3ukp39WVswjx5Y9i2J0gVykGZZFVjkN+vHjKaqocS5TQQps+pNNWNg==', N'211fc134-4647-42c3-8a18-5b4988601060', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b0a9c369-e68f-42d4-ab49-d73ae282223d', N'guest@gmail.com', 0, N'AKi+Yjy7IhDN2wtXv+c5Ck4z0KDdAN3luQrMVMo1f3sUiCsjHFMlowefZQXrFFOpsg==', N'ef9cf559-4add-41db-b828-06f60e0c7df1', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9f587585-a0ef-445f-8672-9ac943af3072', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'51b14893-8230-40fe-811f-103aa4bfaec6', N'9f587585-a0ef-445f-8672-9ac943af3072')

");
        }
        
        public override void Down()
        {
        }
    }
}
