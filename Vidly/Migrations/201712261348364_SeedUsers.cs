namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3323cc51-5fc9-4837-8507-b9cdad64b214', N'admin@vidly.com', 0, N'AMsuMjkolPDIkCHprz/jg9jkLRZAotridCqyvkhp5nxqmX3eU8fu8V/mBa4MkfFCxA==', N'57c49ae5-300c-4431-8c53-cc275b6e7cb6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68d99b25-4f8f-4d1e-90eb-2ad7de77b120', N'guest@vidly.com', 0, N'AKTRCq0JiEpK5fey81F4CeOhcItzKtHfnD41va+pbXCxG4izgHEopOBVQ63HmfRHzA==', N'201a495f-e04e-49eb-b7b1-5b0305a62244', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd502b913-e700-4aa9-8cb4-34ca26debb0c', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3323cc51-5fc9-4837-8507-b9cdad64b214', N'd502b913-e700-4aa9-8cb4-34ca26debb0c')");
        }

        public override void Down()
        {
        }
    }
}
