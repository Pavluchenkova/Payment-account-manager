﻿using System;

namespace Server
{
    public class UserHistory
    {
        public Guid UserHistoryId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime ValidTillDate { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime MonthlyFeeDate { get; set; }
        public string Notes { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
