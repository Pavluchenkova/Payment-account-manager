using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.AccountService;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Type serviceType = typeof(AccountService.AccountService);
            Uri serviceUri = new Uri("http://localhost:8080/");
            ServiceHost host = new ServiceHost(serviceType, serviceUri);
            host.AddDefaultEndpoints();
            host.Open();
            Console.WriteLine("Server started. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
