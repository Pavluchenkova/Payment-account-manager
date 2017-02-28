using Server.AccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Interfaces
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        UserDto GetByAccountNumber(int accountNumber);

        [OperationContract]
        void Update(UserDto userDto);

        [OperationContract]
        void MonthlyFee();
    }
}
