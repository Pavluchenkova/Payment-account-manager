using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data
{
    class UserContextInitialiser : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            User user1 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 123456,
                Balance = 10000m,
                CreationDate = new DateTime(2000, 3, 1),
                IncomeDate = new DateTime(2017, 1, 10),
                ModificationDate = new DateTime(2017, 2, 15),
                ValidTillDate = new DateTime(2020, 3, 1),
                Name = "Helen Johnes",
                Phone = "0987654321",
            };

            User user2 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 223456,
                Balance = 20000m,
                CreationDate = new DateTime(2002, 3, 1),
                IncomeDate = new DateTime(2016, 12, 10),
                ModificationDate = new DateTime(2017, 1, 15),
                ValidTillDate = new DateTime(2022, 3, 1),
                Name = "Serg Zhuk",
                Phone = "0987654000",
                Notes = "VIP account"
            };
            User user3 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 323456,
                Balance = 30000m,
                CreationDate = new DateTime(2010, 3, 1),
                IncomeDate = new DateTime(2017, 1, 12),
                ModificationDate = new DateTime(2017, 2, 20),
                ValidTillDate = new DateTime(2025, 12, 1),
                Name = "Kate McGonigal",
                Phone = "0987654777",
                Notes = "VIP account"
            };
            User user4 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 423456,
                Balance = 100000m,
                CreationDate = new DateTime(2000, 12, 1),
                IncomeDate = new DateTime(2017, 1, 12),
                ModificationDate = new DateTime(2017, 1, 20),
                ValidTillDate = new DateTime(2045, 12, 1),
                Name = "David Draiman",
                Phone = "0876564777",
                Notes = "VIP account"
            };
            db.Users.Add(user1);
            db.Users.Add(user2);
            db.Users.Add(user3);
            db.Users.Add(user4);
            db.SaveChanges();
        }
    }
}
