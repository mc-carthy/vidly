namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19bfc6f0-c84f-45c9-bb24-1d91f3cf3918', N'guest@vidly.com', 0, N'AEmXNFikp7OtoesAjsDUXUbSeqksmvCnLaYbfHVL5sXGA/vYJ4XvoI1zeFnx7qKnxA==', N'bd301ca7-622f-4e1a-bfc6-e84c5ace7f98', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b0ab1425-5a2c-46ea-81dc-fe1fa1539b8d', N'admin@vidly.com', 0, N'AMcAPCnB4XX99aeGjc0qoebX/SiFSDfgFwxejqWdo6vo/ifjiHoDU+kGMWOLSEy1yw==', N'6f4b360c-ce34-4d63-9d82-7b4b4bde7535', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e29d170a-0fa8-4e3e-b975-a13b17d98ee3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b0ab1425-5a2c-46ea-81dc-fe1fa1539b8d', N'e29d170a-0fa8-4e3e-b975-a13b17d98ee3')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
