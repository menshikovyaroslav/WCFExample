using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfLib;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ITransferObject> factory = new ChannelFactory<ITransferObject>(clientBinding, address);
            var service = factory.CreateChannel();

            var sum = service.GetSum(4, 7);
            var multiply = service.GetMultiPly(3, 17);

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"multiply = {multiply}");

            Console.ReadKey();
        }
    }
}
