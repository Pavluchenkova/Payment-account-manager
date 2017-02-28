using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Server.AccountService
{
   [DataContract]
   public class UserDto
    {
        [DataMember]
        public Guid UserId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public decimal Balance { get; set; }
        [DataMember]
        public int AccountNumber { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public DateTime ModificationDate { get; set; }
        [DataMember]
        public DateTime ValidTillDate { get; set; }
        [DataMember]
        public DateTime IncomeDate { get; set; }
        [DataMember]
        public DateTime MonthlyFeeDate { get; set; }
        [DataMember]
        public string Notes { get; set; }
    }
}
