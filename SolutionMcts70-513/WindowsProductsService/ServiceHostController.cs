using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using ProductsServiceLibrary;

namespace WindowsProductsService
{
    public partial class ServiceHostController : ServiceBase
    {
        private ServiceHost productsServiceHost;

        public ServiceHostController()
        {
            InitializeComponent();

            //The name of the service that appears in the Registry
            this.ServiceName = "ProductService";

            //Allow and administrator to stop (and restart) the service
            this.CanStop = true;

            //Report Start and Stop events to the Windows event log
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            productsServiceHost = new ServiceHost(typeof(ProductsServiceImpl));
            NetNamedPipeBinding binding = new NetNamedPipeBinding();
            productsServiceHost.AddServiceEndpoint(typeof(IProductsService), binding, "net.pipe://localhost/ProductsServicePipe");
            productsServiceHost.Open();
        }

        protected override void OnStop()
        {
            productsServiceHost.Close();
        }
    }
}
