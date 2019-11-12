namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(c => c.FirstName, 
                new Friend { FirstName = "Michael", LastName = "Lochman" },
                new Friend { FirstName = "Kelsey", LastName = "Harkness"},
                new Friend { FirstName = "Zak", LastName = "Putman"},
                new Friend { FirstName = "Andy", LastName = "Stoffer"});
        }
    }
}
