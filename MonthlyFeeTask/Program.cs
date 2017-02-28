using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonthlyFeeTask.AccountService;
using System.ServiceModel;

namespace MonthlyFeeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountServiceClient _client = new AccountServiceClient();
            try
            {
                _client.MonthlyFee();
                Console.WriteLine("Monthly fee was collected successfully:)");
            }
            catch (FaultException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
