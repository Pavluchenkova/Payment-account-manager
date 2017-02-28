using System;
using System.Data.Entity;

namespace Server.Data
{
    class UserContextInitialiser : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            User user1 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 26001,
                Balance = 10000m,
                CreationDate = new DateTime(2000, 3, 1),
                IncomeDate = new DateTime(2017, 2, 10),
                MonthlyFeeDate = new DateTime(2017, 3, 10),
                ModificationDate = new DateTime(2017, 2, 15),
                ValidTillDate = new DateTime(2020, 3, 1),
                Name = "Helen Johnes",
                Phone = "0987654321",
            };

            User user2 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 26002,
                Balance = 20000m,
                CreationDate = new DateTime(2002, 3, 1),
                IncomeDate = new DateTime(2016, 12, 30),
                MonthlyFeeDate = new DateTime(2017, 2, 28),
                ModificationDate = new DateTime(2017, 2, 28),
                ValidTillDate = new DateTime(2022, 3, 1),
                Name = "Serg Zhuk",
                Phone = "0987654000",
                Notes = "VIP account"
            };

            User user3 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 26003,
                Balance = 30000m,
                CreationDate = new DateTime(2010, 3, 1),
                IncomeDate = new DateTime(2016, 12, 25),
                MonthlyFeeDate = new DateTime(2017, 3, 25),
                ModificationDate = new DateTime(2017, 2, 12),
                ValidTillDate = new DateTime(2025, 12, 1),
                Name = "Kate McGonigal",
                Phone = "0987654777",
                Notes = "VIP account"
            };

            User user4 = new User
            {
                UserId = Guid.NewGuid(),
                AccountNumber = 26004,
                Balance = 100000m,
                CreationDate = new DateTime(2000, 12, 1),
                IncomeDate = new DateTime(2017, 1, 25),
                MonthlyFeeDate = new DateTime(2017, 2, 12),
                ModificationDate = new DateTime(2017, 2, 25),
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
