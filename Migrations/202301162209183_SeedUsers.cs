namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4e18cb52-eea6-4b91-aac9-17424abbc370', N'admin@vidly.com', 0, N'ANK9e0jA4x7Gyv82ZNrJu1RuzSvtYdemTJ0rWi2l/QrpU/LDG2KOu0nUk/eQa/3acw==', N'0fadd31c-5102-4c31-97e5-ecf0ab6e3661', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f7447a35-b992-41f8-a897-86bfbee30915', N'guest@vidly.com', 0, N'AJI6acx1PlxEY2TG05xVa6UKndr8C7Ypzb/dnOYMiV4a4ov1LslYql2KLw++wGU3Ig==', N'e1f6241f-68f6-4a44-824e-faae33c51fb3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0fec7e13-07d9-440d-8623-2d8c39d75adc', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4e18cb52-eea6-4b91-aac9-17424abbc370', N'0fec7e13-07d9-440d-8623-2d8c39d75adc')");
        }
        
        public override void Down()
        {
        }
    }
}
