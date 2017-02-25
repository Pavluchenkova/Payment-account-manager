using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class UserRepository
    {
        private readonly UserContext _dbContext;

        public UserRepository(UserContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User GetByAccountNumber(int accountNumber)
        {
            var entity = _dbContext.Set<User>().FirstOrDefault(e => e.AccountNumber == accountNumber);

            return entity;
        }

        public void Update(User entity)
        {
            entity.ModificationDate = DateTime.Now;
            entity.UserHistories.Add(new UserHistory
            {
                UserHistoryId = Guid.NewGuid(),
                UserId = entity.UserId,
                Name = entity.Name,
                Phone = entity.Phone,
                Balance = entity.Balance,
                AccountNumber = entity.AccountNumber,
                CreationDate = entity.CreationDate,
                ModificationDate = entity.ModificationDate,
                ValidTillDate = entity.ValidTillDate,
                IncomeDate = entity.IncomeDate,
                Notes = entity.Notes,
            });

            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    }
}
