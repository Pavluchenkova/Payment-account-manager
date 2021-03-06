﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Server.Repositories
{
    public class UserRepository
    {
        private readonly UserContext _dbContext;

        public UserRepository()
        {
            _dbContext = new UserContext();
        }

        public User GetByAccountNumber(int accountNumber)
        {
            var entity = _dbContext.Set<User>().FirstOrDefault(e => e.AccountNumber == accountNumber);

            return entity;
        }

        public User GetById(Guid userId)
        {
            var entity = _dbContext.Set<User>().FirstOrDefault(e => e.UserId == userId);

            return entity;
        }

        public IEnumerable<User> GetUsersForMonthlyFee()
        {
            var currentDay = DateTime.Now;

            return _dbContext.Set<User>().Where(e => (e.MonthlyFeeDate <= currentDay)).ToList();
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
                MonthlyFeeDate = entity.MonthlyFeeDate,
                ValidTillDate = entity.ValidTillDate,
                IncomeDate = entity.IncomeDate,
                Notes = entity.Notes,
            });

            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
