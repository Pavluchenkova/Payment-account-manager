using Server.AccountService;
using System.ServiceModel;

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
