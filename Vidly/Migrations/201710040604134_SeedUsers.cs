namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql
                (@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d149145-6815-4605-bbbf-aea71a26229d', N'guest@vidly.com', 0, N'AAF+xoYUG+hsFmKGumH5TjD11hVDy53xVep/Ycbq4uEr9mb1CR9fpZ9G5MosAoEHSw==', N'b126a2b4-59eb-47cc-9cc7-c8529a38fbb8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cb965776-1030-46fe-9978-a1a6034e243d', N'admin@vidly.com', 0, N'AEuQjSD6Q/4PuTLZjP1zckqK7o45e3YiB55xKXGR2qum7v1sMu+MDkMQ+wrYJoRlSA==', N'aeeb0cbf-8684-4cc1-bb08-036f0d518aed', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f0f03e6a-c40e-4f60-917a-90528cd83cb9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cb965776-1030-46fe-9978-a1a6034e243d', N'f0f03e6a-c40e-4f60-917a-90528cd83cb9')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
