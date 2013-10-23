using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using EvaluateService;

namespace EvalServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(EvalService));

            /*
            host.AddServiceEndpoint(typeof (IEvalService),
                new BasicHttpBinding(),
                "http://localhost:8085/evals/basic");
            host.AddServiceEndpoint(typeof (IEvalService),
                new NetTcpBinding(),
                "net.tcp://localhost:8081/evals");
            host.AddServiceEndpoint(typeof (IEvalService),
                new WSHttpBinding(),
                "http://localhost:8085/evals/ws");
            */

            //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            //smb.HttpGetEnabled = true;
            //smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;

            //var sdb = new ServiceDebugBehavior();
            //sdb.IncludeExceptionDetailInFaults = true;

            //var behavior = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            //behavior.IncludeExceptionDetailInFaults = true;

            try
            {
                PrintServiceInfo(host);
                host.Open();
                Console.WriteLine("Host Opened, press any key to close the host.");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                host.Abort();
                throw;
            }
        }

        public static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} is up and running these endpoints", host.Description.ServiceType);
            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine(endpoint.Address + " " + endpoint.Binding + " " + endpoint.Contract);
            }
        }
    }
}
