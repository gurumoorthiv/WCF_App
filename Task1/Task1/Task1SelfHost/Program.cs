using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Task1ServiceLib;

namespace Task1SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8090/Service1.svc");
            Uri uriTCP = new Uri("net.tcp://localhost:8090/Service1.svc");
            ServiceHost host = new ServiceHost(typeof(Service1));
            //ServiceHost hostTCP = new ServiceHost(typeof(Service1), uriTCP);
            if (host != null)
            {
                //host.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), "");
                //var netTcpBinding = new NetTcpBinding();
                //netTcpBinding.PortSharingEnabled = true;

                //host.AddServiceEndpoint(typeof(IService1), netTcpBinding, "NetTcpBinding_IService1");
                //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //smb.HttpGetEnabled = true;
                
                //host.Description.Behaviors.Add(smb);
                
                host.Open();

                //hostTCP.AddServiceEndpoint(typeof(IService1), new NetTcpBinding(), "net.tcp://localhost:51169/Service1.svc");
                //ServiceMetadataBehavior smbTCP = new ServiceMetadataBehavior();
                //smbTCP.HttpGetEnabled = true;
                
                //hostTCP.Description.Behaviors.Add(smbTCP);
                //hostTCP.Open();
                Console.WriteLine("Service started");
                Console.WriteLine("Press any key to close the Service connection");
                Console.ReadLine();
                host.Close();
                //hostTCP.Close();
            }
        }
    }
}
