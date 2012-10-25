using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");
            var proxy = ChannelFactory<IHelloIndigoService>.CreateChannel(new BasicHttpBinding(), endpoint);

            var s = proxy.HelloIndigo();
            Console.WriteLine(s);

            Console.WriteLine("Press <ENTER> to terminate the service host");
            Console.ReadLine();
        }
    }
}
