using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Membership
    {
        public (AccountCreationStatus status, User user) CreateUser(string username, int password)
        {
            User user1 = new User()
            {
                Username = username,
                Password = password
            };

            AccountCreationStatus status = StoreInDatabase(user1);
            return (status, user1);

        }


        public AccountCreationStatus StoreInDatabase(User user)
        {
            return AccountCreationStatus.success;
        }
    }
}
