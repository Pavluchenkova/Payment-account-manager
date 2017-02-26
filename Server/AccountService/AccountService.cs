﻿using Server.AccountService;
using Server.Interfaces;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly UserRepository _userRpository;

        public AccountService()
        {
            _userRpository = new UserRepository();
        }

        public UserDto GetByAccountNumber(int accountNumber)
        {
            User user = _userRpository.GetByAccountNumber(accountNumber);

            if (user == null)
            {
                return null;
            }
            UserDto userDto = new UserDto
            {
                AccountNumber = user.AccountNumber,
                Balance = user.Balance,
                CreationDate = user.CreationDate,
                IncomeDate = user.IncomeDate,
                ModificationDate = user.ModificationDate,
                Name = user.Name,
                Notes = user.Notes,
                Phone = user.Phone,
                UserId = user.UserId,
                ValidTillDate = user.ValidTillDate
            };
            return userDto;
        }

        public void Update(UserDto userDto)
        {
            User user = _userRpository.GetById(userDto.UserId);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }
            user.Balance = userDto.Balance;
            user.IncomeDate = userDto.IncomeDate;
            user.Name = userDto.Name;
            user.Phone = userDto.Phone;
            user.Notes = userDto.Notes;

            _userRpository.Update(user);
        }

    }
}
