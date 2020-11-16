using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfLib;

namespace WcfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            var host = new ServiceHost(typeof(TransferObject), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
            var serverBinding = new NetTcpBinding();
            host.AddServiceEndpoint(typeof(ITransferObject), serverBinding, "");
            host.Open();

            Console.ReadKey();
        }
    }
}
