namespace Easyserviceapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class easyserviceinitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Easyservices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        FullName = c.String(),
                        NationalId = c.Int(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        Profession = c.String(),
                        ProfilePicture = c.String(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Location = c.String(),
                        MoreBio = c.String(),
                        Comments = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Easyservices");
        }
    }
}
