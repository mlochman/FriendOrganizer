using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Load data from a real database
            yield return new Friend { FirstName = "Michael", LastName = "Lochman", Email = "mlochman@gmail.com"};
            yield return new Friend { FirstName = "Kelsey", LastName = "Harkness", Email = "Kharkness@gmail.com" };
            yield return new Friend { FirstName = "Zak", LastName = "Putman", Email = "zputman@gmail.com" };
            yield return new Friend { FirstName = "Andy", LastName = "Stoffer", Email = "astoffer@gmail.com" };
        }
    }
}
