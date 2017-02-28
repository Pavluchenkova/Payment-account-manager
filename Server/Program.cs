using System;
using System.ServiceModel;
using System.ServiceModel.Description;

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
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            host.Description.Behaviors.Add(behavior);
            host.AddServiceEndpoint(
                typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(),
              "http://localhost:8080/mex");

            host.Open();

            Console.WriteLine("Server started. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
