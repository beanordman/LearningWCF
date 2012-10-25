using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ServiceFromScratch.HelloIndigoService), new Uri("http://localhost:8000/HelloIndigo")))
            {
                host.AddServiceEndpoint(typeof (ServiceFromScratch.IHelloIndigoService), new BasicHttpBinding(),
                                        "HelloIndigoService");
                host.Open();

                Console.WriteLine("Press <ENTER> to terminate the service host");
                Console.ReadLine();
            }
        }
    }
}
